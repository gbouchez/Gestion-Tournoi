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
    public partial class GererException : Form
    {
        SQLiteDatabase db;

        public GererException()
        {
            InitializeComponent();
        }

        private void GererException_Load(object sender, EventArgs e)
        {
            try
            {
                db = new SQLiteDatabase();
                String query = "SELECT equipe1_id, equipe2_id, e1.nom as nom1, e2.nom as nom2 FROM exception"
                + " LEFT JOIN equipe e1 ON equipe1_id = e1.id"
                + " LEFT JOIN equipe e2 ON equipe2_id = e2.id";
                DataTable exceptions = db.GetDataTable(query);
                dataGridView1.DataSource = exceptions;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Equipe 1";
                dataGridView1.Columns[3].HeaderText = "Equipe 2";
            }
            catch (Exception ex)
            {
            }

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
