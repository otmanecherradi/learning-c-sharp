using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0227
{
    class Article
    {
        private int numero;
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value >= 101 && value <= 999)
                    numero = value;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 25 && !char.IsDigit(value[0]))
                    description = value;
            }
        }
        private double prixUnitaire;
        public double PrixUnitaire
        {
            get
            {
                return prixUnitaire;
            }
            set
            {
                if (value > 0)
                    prixUnitaire = value;
            }
        }
        private DateTime dateExperation;
        public DateTime DateExperation
        {
            get
            {
                return dateExperation;
            }
            set
            {
                if (value > DateTime.Parse("05/31/2017"))
                    dateExperation = value;
            }
        }

        public Article() { }

        public Article(int n)
        {
            numero = n;
        }

        public Article(int n, string d, double p, DateTime dt) : this(n)
        {
            description = d;
            prixUnitaire = p;
            dateExperation = dt;
        }

        public void EffectuerReduction(double taux)
        {
            prixUnitaire -= prixUnitaire * taux;
        }

        public bool EstPerime()
        {
            return dateExperation < DateTime.Now;
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Produit {{\n\tNumero = {numero};\n\tDescription {description};\n\tPrix Unitaire = {prixUnitaire};\n\tDate Experation = {dateExperation};\n}}\n");
        }

        public override string ToString()
        {
            return $"Produit {{\n\tNumero = {numero};\n\tDescription {description};\n\tPrix Unitaire = {prixUnitaire};\n\tDate Experation = {dateExperation};\n}}\n";
        }
    }
}