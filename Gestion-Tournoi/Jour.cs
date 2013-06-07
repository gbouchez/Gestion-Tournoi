using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Gestion_Tournoi
{
    public class Jour
    {
        public int maxH;
        public List<Match> horaire1 = new List<Match>();
        public List<Match> horaire2 = new List<Match>();

        public Jour(Dictionary<int, Personne> arbitres, int nbterrains)
        {
            int nbArbitres = arbitres.Count;
            int maxParHoraire = nbArbitres;
            if (nbterrains < nbArbitres)
            {
                maxParHoraire = nbterrains;
            }
            this.maxH = maxParHoraire;
        }

        public void addMatch(Match m)
        {
            if (horaire1.Count == maxH)
            {
                horaire2.Add(m);
            }
            else
            {
                horaire1.Add(m);
            }
        }

        public Boolean isDayFull()
        {
            return (horaire1.Count + horaire2.Count >= maxH * 2);
        }

        public Boolean equipeJoue(Equipe equ)
        {
            Boolean joue = false;
            foreach (Match m in horaire1)
            {
                if (m.equipeJoue(equ))
                {
                    joue = true;
                }
            }
            foreach (Match m in horaire2)
            {
                if (m.equipeJoue(equ))
                {
                    joue = true;
                }
            }
            return joue;
        }

        public Boolean peutJouer(Match m)
        {
            if (m.Joue)
            {
                return false;
            }
            foreach (KeyValuePair<int, Equipe> equipe in m.Equipes)
            {
                if (this.equipeJoue(equipe.Value))
                {
                    return false;
                }
            }
            return true;
        }


        public void setMatchs(List<Match> lm)
        {
            foreach (Match m in lm)
            {
                if (peutJouer(m) && !isDayFull())
                {
                    addMatch(m);
                    m.Joue = true;
                }
            }
        }
    }
}
