using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Tournoi
{
    public class Poule
    {
        public Dictionary<int, Equipe> Equipes = new Dictionary<int, Equipe>();
        int equipesMax = 0;
        public List<Match> matchs = new List<Match>();

        public Poule(int equipesMax)
        {
            this.equipesMax = equipesMax;
        }

        public Boolean isFull()
        {
            return Equipes.Count == equipesMax;
        }
    }
}
