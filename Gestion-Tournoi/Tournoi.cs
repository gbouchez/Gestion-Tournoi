using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Gestion_Tournoi
{
    public class Tournoi
    {
        SQLiteDatabase db = new SQLiteDatabase();
        private int nbEquipes;
        public Dictionary<int, Poule> Poules = new Dictionary<int, Poule>();
        private Dictionary<int, Equipe> Equipes = new Dictionary<int, Equipe>();
        public Dictionary<int, Personne> Arbitres = new Dictionary<int, Personne>();
        public Dictionary<int, Personne> Joueurs = new Dictionary<int, Personne>();
        public List<Jour> cal = new List<Jour>();
        public List<Match> matchs = new List<Match>();

        public Tournoi()
        {
            String query = "select count(*) from equipe";
            nbEquipes = Int32.Parse(db.ExecuteScalar(query));
            query = "select * from equipe";
            DataTable data = db.GetDataTable(query);
            foreach (DataRow row in data.Rows)
            {
                Equipe equ = new Equipe(Int32.Parse(row["id"].ToString()), row["nom"].ToString(), Int32.Parse(row["capitaine_id"].ToString()));
                this.Equipes[equ.id] = equ;
            }

            query = "select * from personne where equipe_id is null and arbitre = 1";
            DataTable arb = db.GetDataTable(query);
            foreach (DataRow row in arb.Rows)
            {
                Personne pers;
                if (row["equipe_id"] == System.DBNull.Value)
                {
                    pers = new Personne(Int32.Parse(row["id"].ToString()), row["prenom"].ToString(), row["nom"].ToString(), 0, true);
                }
                else
                {
                    pers = new Personne(Int32.Parse(row["id"].ToString()), row["prenom"].ToString(), row["nom"].ToString(), Int32.Parse(row["equipe_id"].ToString()), true);
                }
                
                this.Arbitres[pers.id] = pers;
            }

            query = "select * from personne where equipe_id is not null and equipe_id > 0";
            DataTable players = db.GetDataTable(query);
            foreach (DataRow row in players.Rows)
            {
                Personne pers;
                pers = new Personne(Int32.Parse(row["id"].ToString()), row["prenom"].ToString(), row["nom"].ToString(), Int32.Parse(row["equipe_id"].ToString()), false);

                this.Joueurs[pers.id] = pers;
            }
            foreach (KeyValuePair<int, Equipe> equipe in this.Equipes)
            {
                equipe.Value.setJoueurs(this.Joueurs);
            }
        }

        public Dictionary<int, Dictionary<int, int>> getPossiblesPoules()
        {
            Dictionary<int, Dictionary<int, int>> poules = new Dictionary<int, Dictionary<int, int>>();
            int i;
            for (i = 3; i <= 6; i++)
            {
                if (nbEquipes >= i)
                {
                    if (!((Math.Floor((double)nbEquipes/i) - nbEquipes % i) <= 0
                        || (nbEquipes % i > 0 && i+1 > 6)))
                    {
                        Dictionary<int, int> sPoule = new  Dictionary<int, int>();
                        sPoule[i] = (int)(Math.Floor((double)nbEquipes / i) - nbEquipes % i);
                        sPoule[i + 1] = nbEquipes % i;
                        poules[i] = sPoule;
                    }
                }
            }
            return poules;
        }

        public void setPoules(Dictionary<int, int> poules)
        {
            int i;
            int index = 0;
            foreach (KeyValuePair<int, int> nb in poules)
            {
                for (i = 0; i < nb.Value; i++)
                {
                    index++;
                    Poule nPoule = new Poule(nb.Key);
                    this.Poules[index] = nPoule;
                }
            }
            index = 1;
            foreach (KeyValuePair<int, Equipe> equ in this.Equipes)
            {
                if (this.Poules[index].isFull())
                {
                    index++;
                }
                this.Poules[index].Equipes[equ.Key] = equ.Value;
                equ.Value.poule = this.Poules[index];
            }
        }

        public void setMatchs()
        {
            int i;
            int j;
            foreach (KeyValuePair<int, Poule> poule in this.Poules)
            {
                Array equipes = poule.Value.Equipes.ToArray();
                for (i = 0; i < equipes.Length; i++)
                {
                    for (j = i + 1; j < equipes.Length; j++)
                    {
                        Match mat = new Match(this.Equipes[((KeyValuePair<int, Equipe>)equipes.GetValue(i)).Key], this.Equipes[((KeyValuePair<int, Equipe>)equipes.GetValue(j)).Key]);
                        this.Equipes[((KeyValuePair<int, Equipe>)equipes.GetValue(i)).Key].matchs.Add(mat);
                        this.Equipes[((KeyValuePair<int, Equipe>)equipes.GetValue(j)).Key].matchs.Add(mat);
                        poule.Value.matchs.Add(mat);
                        this.matchs.Add(mat);
                    }
                }
            }

            Jour jour;
            while (this.resteMatchsAJouer())
            {
                jour = new Jour(this.Arbitres, Properties.Settings.Default.nbTerrains);
                this.cal.Add(jour);
                jour.setMatchs(this.matchs);
            }
        }

        public Boolean resteMatchsAJouer()
        {
            Boolean reste = false;
            foreach (Match m in this.matchs)
            {
                if (m.Joue == false)
                {
                    reste = true;
                }
            }
            return reste;
        }

        public void ecrireFichier(System.IO.StreamWriter file)
        {
            file.WriteLine("---------------------------------\n"
                +"|      Gestion de tournoi       |"
                +"\n---------------------------------\n");
            file.WriteLine("----- Présentation des équipes : -----\n");
            foreach (KeyValuePair<int, Equipe> equ in this.Equipes)
            {
                Equipe equipe = equ.Value;
                file.WriteLine("Equipe " + equipe.id + " : " + equipe.nom);
                file.WriteLine(equipe.capitaine.prenom + " " + equipe.capitaine.nom + " (Capitaine)");
                foreach (Personne joueur in equipe.joueurs)
                {
                    if (joueur.id != equipe.capitaine_id)
                    {
                        file.WriteLine(joueur.prenom + " " + joueur.nom);
                    }
                }
                file.WriteLine("");
            }
            file.WriteLine("----- Présentation des arbitres : -----\n");
            foreach (KeyValuePair<int, Personne> ar in this.Arbitres)
            {
                Personne arbi = ar.Value;
                file.WriteLine(arbi.prenom + " " + arbi.nom);
            }
            file.WriteLine("\n\n---------------------------------\n"
                +"|   Organisation du tournoi     |\n"
                +"---------------------------------");
            int semaine = 0;
            int curDay = 1;
            int jours = Properties.Settings.Default.jours;
            List<String> possibleJours = new List<String> { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            List<String> joursReels = new List<String>();
            int nbDiffJours = 0;
            int i;
            for (i = 0; i <= 6; i++)
            {
                if ((jours & (int)Math.Pow(2, i)) == (int)Math.Pow(2, i))
                {
                    nbDiffJours++;
                    joursReels.Add(possibleJours[i]);
                }
            }
            int numTerrain;
            int numArbitre;
            foreach (Jour jour in this.cal)
            {
                if ((curDay - 1) % nbDiffJours == 0)
                {
                    semaine++;
                    file.WriteLine("\nSemaine "+semaine.ToString()+" : \n");
                }
                file.WriteLine(joursReels[(curDay - 1) % nbDiffJours]);
                file.WriteLine("12h30:");
                numTerrain = 0;
                numArbitre = 0;
                List<KeyValuePair<int, Personne>> arb = this.Arbitres.ToList();
                foreach (Match m in jour.horaire1)
                {
                    numTerrain++;
                    file.WriteLine("Terrain " + numTerrain.ToString() + " : " + m.getEquipe1().nom + " VS " + m.getEquipe2().nom+" (Arbitre : "+arb[numArbitre].Value.prenom+ " "+arb[numArbitre].Value.nom+")");
                    numArbitre++;
                }
                if (jour.horaire2.Count > 0)
                {
                    file.WriteLine("13h:");
                    numTerrain = 0;
                    numArbitre = 0;
                    foreach (Match m in jour.horaire2)
                    {
                        numTerrain++;
                        file.WriteLine("Terrain " + numTerrain.ToString() + " : " + m.getEquipe1().nom + " VS " + m.getEquipe2().nom + " (Arbitre : " + arb[numArbitre].Value.prenom + " " + arb[numArbitre].Value.nom + ")");
                        numArbitre++;
                    }
                }

                file.WriteLine("");

                curDay++;
            }
        }
    }
}
