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
    public partial class NouvellePersonne : Form
    {
        SQLiteDatabase db;

        public NouvellePersonne()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("prenom", this.tb_prenom.Text);
            data.Add("nom", this.tb_nom.Text);
            if (this.cb_arbitre.Checked)
            {
                data.Add("arbitre", "1");
            }
            else
            {
                data.Add("arbitre", "0");
            }
            try
            {
                db.Insert("personne", data);
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
            this.Close();


        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NouvellePersonne_Load(object sender, EventArgs e)
        {

        }
    }
}
