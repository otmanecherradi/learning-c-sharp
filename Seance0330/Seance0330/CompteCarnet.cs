using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0330
{
    class CompteCarnet : Compte
    {
        private double tauxInteret;
        public double TauxInteret { get => tauxInteret; set => tauxInteret = value; }


        public CompteCarnet() : base() { }

        public CompteCarnet(int numCompte, DateTime dateCompte, double soldeCompte, Client propCompte, double tauxInteret) : base(numCompte, dateCompte, soldeCompte, propCompte)
        {
            TauxInteret = tauxInteret;
        }


        public override void retrait(double amount)
        {
            if (amount <= soldeCompte)
                Console.WriteLine("Retrait Impossible");
            else
                base.retrait(amount);
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumCompte = {numCompte}\n\tDateCompte = {dateCompte}\n\tSoldeCompte = {soldeCompte}\n\tPropCompte = {propCompte}\n\tTauxInteret = {TauxInteret}\n}}";
        }
    }
}
