using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Tournoi
{
    public class Personne
    {
        public int id;
        public String prenom;
        public String nom;
        public int equipe_id;
        public Boolean arbitre;

        public Personne(int id, String prenom, String nom, int equipe_id, Boolean arbitre)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.equipe_id = equipe_id;
            this.arbitre = arbitre;
        }
    }
}
