using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Tournoi
{
    public class Equipe
    {
        public int id;
        public String nom;
        public Poule poule;
        public List<Match> matchs = new List<Match>();
        public List<Personne> joueurs = new List<Personne>();
        public Personne capitaine;
        public int capitaine_id;

        public Equipe(int id, String nom, int capitaine_id)
        {
            this.id = id;
            this.nom = nom;
            this.capitaine_id = capitaine_id;
        }

        public void setJoueurs(Dictionary<int, Personne> joueurs)
        {
            foreach (KeyValuePair<int, Personne> joueur in joueurs)
            {
                if (joueur.Value.equipe_id == this.id)
                {
                    this.joueurs.Add(joueur.Value);
                    if (joueur.Value.id == this.capitaine_id)
                    {
                        this.capitaine = joueur.Value;
                    }
                }
            }
        }
    }
}
