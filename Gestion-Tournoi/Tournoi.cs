﻿using System;
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

            query = "select * from exception";
            DataTable dataExc = db.GetDataTable(query);
            foreach (DataRow row in dataExc.Rows)
            {
                this.Equipes[Int32.Parse(row["equipe1_id"].ToString())].exceptions.Add(Int32.Parse(row["equipe2_id"].ToString()));
                this.Equipes[Int32.Parse(row["equipe2_id"].ToString())].exceptions.Add(Int32.Parse(row["equipe1_id"].ToString()));
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
                        Equipe equ1 = this.Equipes[((KeyValuePair<int, Equipe>)equipes.GetValue(i)).Key];
                        Equipe equ2 = this.Equipes[((KeyValuePair<int, Equipe>)equipes.GetValue(j)).Key];
                        if (equ1.peutJouerContre(equ2))
                        {
                            Match mat = new Match(equ1, equ2);
                            equ1.matchs.Add(mat);
                            equ2.matchs.Add(mat);
                            poule.Value.matchs.Add(mat);
                            this.matchs.Add(mat);
                        }
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
            file.Write(this.getTexteJoueurs());
            file.WriteLine("----- Présentation des arbitres : -----\n");
            file.Write(this.getTexteArbitres());
            file.WriteLine("\n\n---------------------------------\n"
                +"|   Organisation du tournoi     |\n"
                +"---------------------------------");
            file.Write(this.getTexteCalendrier());
        }

        public String getTexteJoueurs()
        {
            String text = "";
            int pouleId = 0;
            foreach (KeyValuePair<int, Poule> poule in this.Poules)
            {
                pouleId++;
                text += "Poule " + pouleId.ToString()+"\r\n\r\n";
                foreach (KeyValuePair<int, Equipe> equ in poule.Value.Equipes)
                {
                    Equipe equipe = equ.Value;
                    text += "Equipe " + equipe.id + " : " + equipe.nom + "\r\n";
                    text += equipe.capitaine.prenom + " " + equipe.capitaine.nom + " (Capitaine)\r\n";
                    foreach (Personne joueur in equipe.joueurs)
                    {
                        if (joueur.id != equipe.capitaine_id)
                        {
                            text += joueur.prenom + " " + joueur.nom+"\r\n";
                        }
                    }
                    text += "\r\n";
                }
            }
            return text;
        }

        public String getTexteArbitres()
        {
            String text = "";
            foreach (KeyValuePair<int, Personne> ar in this.Arbitres)
            {
                Personne arbi = ar.Value;
               text += arbi.prenom + " " + arbi.nom +"\r\n";
            }
            return text;
        }

        public String getTexteCalendrier()
        {
            String text = "";

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
                    text += "\r\nSemaine " + semaine.ToString() + " : \r\n\r\n";
                }
                text += joursReels[(curDay - 1) % nbDiffJours] + "\r\n";
                text += "12h30:\r\n";
                numTerrain = 0;
                numArbitre = 0;
                List<KeyValuePair<int, Personne>> arb = this.Arbitres.ToList();
                foreach (Match m in jour.horaire1)
                {
                    numTerrain++;
                    text += "Terrain " + numTerrain.ToString() + " : " + m.getEquipe1().nom + " VS " + m.getEquipe2().nom + " (Arbitre : " + arb[numArbitre].Value.prenom + " " + arb[numArbitre].Value.nom + ")\r\n";
                    numArbitre++;
                }
                if (jour.horaire2.Count > 0)
                {
                    text += "13h:\r\n";
                    numTerrain = 0;
                    numArbitre = 0;
                    foreach (Match m in jour.horaire2)
                    {
                        numTerrain++;
                        text += "Terrain " + numTerrain.ToString() + " : " + m.getEquipe1().nom + " VS " + m.getEquipe2().nom + " (Arbitre : " + arb[numArbitre].Value.prenom + " " + arb[numArbitre].Value.nom + ")\r\n";
                        numArbitre++;
                    }
                }

                text += "\r\n";

                curDay++;
            }

            return text;
        }
    }
}
