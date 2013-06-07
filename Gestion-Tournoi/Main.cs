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
    public partial class Main : Form
    {
        SQLiteDatabase db;
        private Boolean init = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dbDataSet.equipe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipeTableAdapter.Fill(this.dbDataSet.equipe);
            // TODO: cette ligne de code charge les données dans la table 'dbDataSet.personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.dbDataSet.personne);
            tb_nbTerrains.Text = Properties.Settings.Default.nbTerrains.ToString();

            setDaysChecked();
        }

        private void bt_newpers_Click(object sender, EventArgs e)
        {
            updateAll();
            NouvellePersonne np = new NouvellePersonne();
            np.ShowDialog();
            this.personneTableAdapter.Fill(this.dbDataSet.personne);
            updateAll();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateAll();
        }

        private void dataGridView2_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateAll();
        }

        private void bt_newteam_Click(object sender, EventArgs e)
        {
            updateAll();
            NouvelleEquipe ne = new NouvelleEquipe(0);
            ne.ShowDialog();
            this.equipeTableAdapter.Fill(this.dbDataSet.equipe);
            updateAll();
        }

        private void updateAll()
        {
            this.personneTableAdapter.Update(this.dbDataSet.personne);
            this.equipeTableAdapter.Update(this.dbDataSet.equipe);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.updateAll();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.updateAll();
        }

        private void bt_editTeam_Click(object sender, EventArgs e)
        {
            updateAll();
            NouvelleEquipe ne = new NouvelleEquipe(Int32.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
            ne.ShowDialog();
            this.equipeTableAdapter.Fill(this.dbDataSet.equipe);
            updateAll();
        }

        private void tb_nbTerrains_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void tb_nbTerrains_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.nbTerrains = Int32.Parse(tb_nbTerrains.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_lundi_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_lundi.Checked)
                {
                    Properties.Settings.Default.jours += 1;
                }
                else
                {
                    Properties.Settings.Default.jours -= 1;
                }
            }
        }

        private void setDaysChecked()
        {
            this.init = true;
            if ((Properties.Settings.Default.jours & 1) == 1)
            {
                cb_lundi.Checked = true;
            }

            if ((Properties.Settings.Default.jours & 2) == 2)
            {
                cb_mardi.Checked = true;
            }
            if ((Properties.Settings.Default.jours & 4) == 4)
            {
                cb_mercredi.Checked = true;
            }
            if ((Properties.Settings.Default.jours & 8) == 8)
            {
                cb_jeudi.Checked = true;
            }
            if ((Properties.Settings.Default.jours & 16) == 16)
            {
                cb_vendredi.Checked = true;
            }
            if ((Properties.Settings.Default.jours & 32) == 32)
            {
                cb_samedi.Checked = true;
            }
            if ((Properties.Settings.Default.jours & 64) == 64)
            {
                cb_dimanche.Checked = true;
            }
            this.init = false;
        }

        private void cb_mardi_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_mardi.Checked)
                {
                    Properties.Settings.Default.jours += 2;
                }
                else
                {
                    Properties.Settings.Default.jours -= 2;
                }
            }
        }

        private void cb_mercredi_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_mercredi.Checked)
                {
                    Properties.Settings.Default.jours += 4;
                }
                else
                {
                    Properties.Settings.Default.jours -= 4;
                }
            }
        }

        private void cb_jeudi_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_jeudi.Checked)
                {
                    Properties.Settings.Default.jours += 8;
                }
                else
                {
                    Properties.Settings.Default.jours -= 8;
                }
            }
        }

        private void cb_vendredi_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_vendredi.Checked)
                {
                    Properties.Settings.Default.jours += 16;
                }
                else
                {
                    Properties.Settings.Default.jours -= 16;
                }
            }
        }

        private void cb_samedi_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_samedi.Checked)
                {
                    Properties.Settings.Default.jours += 32;
                }
                else
                {
                    Properties.Settings.Default.jours -= 32;
                }
            }
        }

        private void cb_dimanche_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                if (cb_dimanche.Checked)
                {
                    Properties.Settings.Default.jours += 64;
                }
                else
                {
                    Properties.Settings.Default.jours -= 64;
                }
            }
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            updateAll();
            db = new SQLiteDatabase();
            String query = "select count(*) from equipe";
            int nbEquipes = Int32.Parse(db.ExecuteScalar(query));
            int nbTerrains = Properties.Settings.Default.nbTerrains;
            query = "select count(*) from personne where equipe_id is null and arbitre = 1";
            int nbArbitres = Int32.Parse(db.ExecuteScalar(query));
            Boolean erreur = false;
            if (nbArbitres < 1)
            {
                MessageBox.Show("Il vous faut au moins un arbitre n'appartenant pas à une équipe !");
                erreur = true;
            }
            else if (nbTerrains < 1)
            {
                MessageBox.Show("Il vous faut au moins un terrain disponible !");
                erreur = true;
            } else if (nbEquipes < 3)
            {
                MessageBox.Show("Il vous faut au moins trois équipes !");
                erreur = true;
            }
            else if (!cb_lundi.Checked && !cb_mardi.Checked && !cb_mercredi.Checked && !cb_jeudi.Checked
                && !cb_vendredi.Checked && !cb_samedi.Checked && !cb_dimanche.Checked)
            {
                MessageBox.Show("Il vous faut au moins une journée disponible !");
                erreur = true;
            }
            if (!erreur)
            {
                Tournoi tour = new Tournoi();
                Dictionary<int, Dictionary<int, int>> poules = tour.getPossiblesPoules();
                ChoixPoules cp = new ChoixPoules(tour, poules);
                cp.ShowDialog();
                tour.setMatchs();
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Fichier texte|*.txt";
                saveFile.Title = "Sauvegarder le résumé du tournoi";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(saveFile.FileName);

                    tour.ecrireFichier(file);
                    
                    file.Close();
                }
            }

        }

        private void bt_editIgnore_Click(object sender, EventArgs e)
        {
            GererException excep = new GererException();
            excep.ShowDialog();
        }

    }
}