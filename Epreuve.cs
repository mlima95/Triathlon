using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Epreuve
    {
        private int distance;
        private string nom;
        private int tempsEliminatoire;

        public Epreuve(string nom, int distance)
        {
            this.nom = nom;
            this.distance = distance;
        }

        public int GetDistance()
        {
            return this.distance;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetTempsEliminatoire()
        {
            return this.tempsEliminatoire;
        }

        public void SetTempsEliminatoire(int tempsEliminatoire)
        {
            this.tempsEliminatoire = tempsEliminatoire;
        }
    }
}
