using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Participant
    {
        private int id;
        static private int lastId;
        private string nom;
        private DateTime dateInscription;
        List<Resultat> lesResultats;

        public Participant(string nom, DateTime dateInscription)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
            this.id = lastId;
            this.lesResultats = new List<Resultat>();
            lastId = lastId + 1;
        }
        public DateTime GetDateInscription()
        {
            return this.dateInscription;
        }

        public int GetId()
        {
            return this.id;
        }

        public List<Resultat> LesResultats
        {
            get { return lesResultats; }
        }

        public string GetNom()
        {
            return this.nom;
        }
        public int GetTempsTotal()
        {
            int tempsTotal = 0;

            foreach (Resultat unResultat in lesResultats)
            {
                tempsTotal = unResultat.GetTempsRealise() + tempsTotal;
            }
            return tempsTotal;
        }

        public bool HorsDelai()
        {
            foreach (Resultat unResultat in lesResultats)
            {
                if (unResultat.GetTempsRealise() > unResultat.GetEpreuve().GetTempsEliminatoire())
                {
                    return true;
                }
            }
            return false;
        }

        public bool resultatPresent(Epreuve uneEpreuve)
        {
            foreach (Resultat unResultat in lesResultats)
            {

                if (unResultat.GetEpreuve().GetNom() == uneEpreuve.GetNom())
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Epreuve uneEpreuve, int tempsRealise)
        {
            if (resultatPresent(uneEpreuve) == false)
            {
                Resultat unResulat = new Resultat(this, uneEpreuve, tempsRealise);
                this.lesResultats.Add(unResulat);
            }
        }
    }
}
