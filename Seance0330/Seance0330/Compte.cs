using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0330
{
    abstract class Compte
    {
        protected int numCompte;
        public int NumCompte { get => numCompte; set => numCompte = value; }

        protected DateTime dateCompte;
        public DateTime DateCompte { get => dateCompte; set => dateCompte = value; }

        protected double soldeCompte;
        public double SoldeCompte { get => soldeCompte; set => soldeCompte = value; }

        protected Client propCompte;
        public Client PropCompte { get => propCompte; set => propCompte = value; }


        protected Compte() { }

        protected Compte(int numCompte, DateTime dateCompte, double soldeCompte, Client propCompte)
        {
            NumCompte = numCompte;
            DateCompte = dateCompte;
            SoldeCompte = soldeCompte;
            PropCompte = propCompte;
        }


        public void depot(double amount)
        {
            SoldeCompte += amount;
        }

        public virtual void retrait(double amount)
        {
            SoldeCompte -= amount;
        }

        public override string ToString()
        {

            return $"{GetType().Name} {{\n\tNumCompte = {numCompte}\n\tDateCompte = {dateCompte}\n\tSoldeCompte = {soldeCompte}\n\tPropCompte = {propCompte}\n}}";
        }
    }
}
