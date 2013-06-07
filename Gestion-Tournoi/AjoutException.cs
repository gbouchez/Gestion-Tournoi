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
    public partial class AjoutException : Form
    {
        SQLiteDatabase db;

        public AjoutException()
        {
            InitializeComponent();
        }

        private void AjoutException_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dbDataSet.equipe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipeTableAdapter.Fill(this.dbDataSet.equipe);

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(cb_equipe1.SelectedValue.ToString()) == Int32.Parse(cb_equipe2.SelectedValue.ToString()))
            {
                MessageBox.Show("Vous ne pouvez pas ajouter une exception d'une équipe sur elle-même.");
                return;
            }
            this.db = new SQLiteDatabase();
            String query = "SELECT COUNT(*) FROM exception WHERE equipe1_id = "
            + cb_equipe1.SelectedValue.ToString() + " AND equipe2_id = "
            + cb_equipe2.SelectedValue.ToString() + " OR equipe1_id = "
            + cb_equipe2.SelectedValue.ToString() + " AND equipe2_id = "
            + cb_equipe1.SelectedValue.ToString();
            int count = Int32.Parse(db.ExecuteScalar(query));
            if (count > 0)
            {
                MessageBox.Show("Cette exception est déjà présente dans la base de données.");
                return;
            }
            query = "INSERT INTO exception VALUES (" + cb_equipe1.SelectedValue.ToString()
            + ", " + cb_equipe2.SelectedValue.ToString() + ");";
            this.db.ExecuteNonQuery(query);
            this.Close();
        }
    }
}
