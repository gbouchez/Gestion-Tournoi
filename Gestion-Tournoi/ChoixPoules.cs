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
    public partial class ChoixPoules : Form
    {
        Tournoi tour;
        private Dictionary<int, Dictionary<int, int>> poules;

        public ChoixPoules(Tournoi tourn, Dictionary<int, Dictionary<int, int>> poules)
        {
            Dictionary<string, Dictionary<int, int>> newDic = new Dictionary<string, Dictionary<int, int>>();
            foreach (KeyValuePair<int, Dictionary<int, int>> pair in poules)
            {
                String str = pair.Value[pair.Key].ToString() + " poule(s) de " + pair.Key.ToString();
                if (pair.Value[pair.Key + 1] > 0)
                {
                    str += ", " + pair.Value[pair.Key + 1].ToString() + " poule(s) de " + (pair.Key + 1).ToString();
                }
                newDic[str] = pair.Value;
            }
            tour = tourn;
            this.poules = poules;
            InitializeComponent();
            cb_poules.DataSource = new BindingSource(newDic, null);
            cb_poules.DisplayMember = "Key";
            cb_poules.ValueMember = "Value";

            cb_poules.SelectedIndex = 0;
        }

        private void ChoixPoules_Load(object sender, EventArgs e)
        {

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.tour.setPoules((Dictionary<int, int>)this.cb_poules.SelectedValue);
            this.Close();
        }
    }
}
