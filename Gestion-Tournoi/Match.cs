using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Tournoi
{
    public class Match
    {
        public Dictionary<int, Equipe> Equipes = new Dictionary<int, Equipe>();
        public Poule poule;
        public Boolean Joue = false;

        public Match(Equipe equ1, Equipe equ2)
        {
            this.Equipes[equ1.id] = equ1;
            this.Equipes[equ2.id] = equ2;
            this.poule = equ1.poule;
        }

        public Boolean equipeJoue(Equipe equ)
        {
            Boolean joue = false;
            foreach (KeyValuePair<int, Equipe> equipe in Equipes)
            {
                if (equipe.Value.id == equ.id)
                {
                    joue = true;
                }
            }
            return joue;
        }

        public Equipe getEquipe1()
        {
            return this.Equipes.First().Value;
        }

        public Equipe getEquipe2()
        {
            return this.Equipes.Last().Value;
        }
    }
}
