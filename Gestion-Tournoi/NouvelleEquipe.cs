using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Tournoi
{
    public partial class NouvelleEquipe : Form
    {
        SQLiteDatabase db;
        private int id_equipe;
        DataTable personnes;
        int playerCount = 0;
        int capitaineId = 0;

        public NouvelleEquipe(int id_equipe = 0)
        {
            this.id_equipe = id_equipe;
            InitializeComponent();
        }

        private void NouvelleEquipe_Load(object sender, EventArgs e)
        {
            db = new SQLiteDatabase();
            try
            {
                db = new SQLiteDatabase();

                String query = "";
                if (this.id_equipe != 0)
                {
                    query = "select nom from equipe where id = " + this.id_equipe;
                    String teamName = db.ExecuteScalar(query);
                    tb_nom.Text = teamName;
                    query = "select capitaine_id from equipe where id = " + this.id_equipe;
                    capitaineId = Int32.Parse(db.ExecuteScalar(query));
                }
                
                query = "select * FROM personne WHERE equipe_id is null or equipe_id = 0";
                if (this.id_equipe != 0)
                {
                    query += " or equipe_id = " + this.id_equipe;
                }
                personnes = db.GetDataTable(query);
                DataColumn inTeam = new DataColumn("Selection", typeof(Boolean));
                personnes.Columns.Add(inTeam);
                DataColumn isCap = new DataColumn("Capitaine", typeof(Boolean));
                personnes.Columns.Add(isCap);
                
                foreach (DataRow r in personnes.Rows)
                {
                    if (r["equipe_id"] != System.DBNull.Value)
                    {
                        r["Selection"] = 1;
                        playerCount++;
                    }
                    else
                    {
                        r["Selection"] = 0;
                    }
                    if (Int32.Parse(r["id"].ToString()) == capitaineId)
                    {
                        r["Capitaine"] = 1;
                    }
                    else
                    {
                        r["Capitaine"] = 0;
                    }
                }
                dataGridView1.DataSource = personnes;
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
	
                
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Selection")
            {
                DataGridViewCheckBoxCell checkCell =
                    (DataGridViewCheckBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Selection"];
                if ((Boolean)checkCell.Value)
                {
                    playerCount++;
                }
                else
                {
                    playerCount--;
                }

                if (playerCount == 10)
                {
                    MessageBox.Show("Une équipe ne peut avoir que 9 joueurs au maximum.");
                    dataGridView1.Rows[e.RowIndex].Cells["Selection"].Value = false;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Capitaine")
            {
                DataGridViewCheckBoxCell checkCell =
                    (DataGridViewCheckBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Capitaine"];
                DataGridViewCheckBoxCell checkTeam =
                    (DataGridViewCheckBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Selection"];
                if ((Boolean)checkCell.Value)
                {
                    if ((Boolean)checkTeam.Value)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["id"] != dataGridView1.Rows[e.RowIndex].Cells["id"])
                            {
                                row.Cells["Capitaine"].Value = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le capitaine doit faire partie de l'équipe !");
                        dataGridView1.Rows[e.RowIndex].Cells["Capitaine"].Value = false;
                    }
                }
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (tb_nom.TextLength < 6)
            {
                MessageBox.Show("Le nom de l'équipe doit comporter au moins 6 caractères !");
                return;
            }
            capitaineId = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((Boolean)row.Cells["Capitaine"].Value == true)
                {
                    capitaineId = Int32.Parse(row.Cells["id"].Value.ToString());
                }
            }
            if (playerCount < 6)
            {
                MessageBox.Show("Une équipe doit comporter au minimum 6 joueurs.");
            }
            else if (capitaineId == 0)
            {
                MessageBox.Show("L'équipe doit avoir un capitaine !");
            }
            else
            {
                db = new SQLiteDatabase();
                int idEquipe;
                Dictionary<String, String> data = new Dictionary<String, String>();
                data.Add("nom", this.tb_nom.Text);
                data.Add("capitaine_id", capitaineId.ToString());
                if (this.id_equipe == 0)
                {
                    db.Insert("equipe", data);
                    String query = "select max(id) FROM equipe";
                    idEquipe = Int32.Parse(db.ExecuteScalar(query));
                }
                else
                {
                    db.Update("equipe", data, "id = " + this.id_equipe);
                    idEquipe = this.id_equipe;
                }
                Dictionary<String, String> dataUpdate = new Dictionary<String, String>();
                dataUpdate.Add("equipe_id", "NULL");
                db.Update("personne", dataUpdate, " equipe_id = " + idEquipe);
                string whereString = " id IN (";
                Boolean first = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((Boolean)row.Cells["Selection"].Value)
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                        {
                            whereString += ", ";
                        }
                        whereString += row.Cells["id"].Value.ToString();
                    }
                }
                whereString += ")";
                dataUpdate["equipe_id"] = idEquipe.ToString();
                db.Update("personne", dataUpdate, whereString);

                this.Close();
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
