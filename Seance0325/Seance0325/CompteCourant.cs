using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0325
{
    class CompteCourant : Compte
    {
        private double decouvert;
        public double Decouvert { get => decouvert; set => decouvert = value; }


        public CompteCourant(int numCompte, DateTime dateCompte, double soldeCompte, Client propCompte, double decouvert) : base(numCompte, dateCompte, soldeCompte, propCompte)
        {
            Decouvert = decouvert;
        }


        public override void retrait(double amount)
        {
            if ((soldeCompte <= 0 && amount <= decouvert) || soldeCompte > 0)
                base.retrait(amount);
            else
                throw new Exception("Retrait Impossible");
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumCompte = {numCompte}\n\tDateCompte = {dateCompte}\n\tSoldeCompte = {soldeCompte}\n\tPropCompte = {propCompte}\n\tDecouvert = {Decouvert}\n}}";
        }
    }
}
