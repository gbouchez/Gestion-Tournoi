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
    public partial class Synthese : Form
    {
        Tournoi tournoi;

        public Synthese(Tournoi tour)
        {
            this.tournoi = tour;
            InitializeComponent();
        }

        private void Synthese_Load(object sender, EventArgs e)
        {
            this.tb_teams.Text = tournoi.getTexteJoueurs();
        }

    }
}
