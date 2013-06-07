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
    public partial class SelectionGeneration : Form
    {
        Tournoi tournoi;

        public SelectionGeneration(Tournoi tour)
        {
            this.tournoi = tour;
            InitializeComponent();
        }

        private void SelectionGeneration_Load(object sender, EventArgs e)
        {

        }

        private void bt_genFile_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fichier texte|*.txt";
            saveFile.Title = "Sauvegarder le récapitualtif du tournoi";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFile.FileName);
                tournoi.ecrireFichier(file);
                file.Close();
            }
            this.Close();
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            Synthese synth = new Synthese(tournoi);
            synth.ShowDialog();
            this.Close();
        }
    }
}
