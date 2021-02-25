using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0225
{
    class Produit
    {
        private int code;
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
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
                if (value == "")
                    description = "non saisie";
                else
                    description = value;
            }
        }

        private double prixHT;
        public double PrixHT
        {
            get
            {
                return prixHT;
            }
            set
            {
                prixHT = value;
            }
        }

        private readonly DateTime dateAchat;
        public DateTime DataAchat
        {
            get
            {
                return dateAchat;
            }
        }

        public Produit()
        {
            dateAchat = DateTime.Now;
        }

        public Produit(int c, string d, double p, DateTime dt)
        {
            code = c;
            description = d;
            prixHT = p;
            dateAchat = dt;
        }

        public double PrixTTC(double tva = .2)
        {
            return prixHT + prixHT * tva;
        }

        public void Afficher()
        {
            //Console.WriteLine($"Produit {{\n\tCode = {code};\n\tDescription {description};\n\tPrixHT = {prixHT};\n\tPrixTTC = {PrixTTC()};\n\tDateAchat = {dateAchat}\n}}\n");
            Console.WriteLine($"Produit {{\n\tCode = {code};\n\tDescription {description};\n\tPrixHT = {prixHT};\n\tPrixTTC = {PrixTTC()};\n}}\n");
        }

        public int ComparerPrix(Produit p)
        {
            if (PrixTTC() > p.PrixTTC())
                return 1;
            else if (PrixTTC() < p.PrixTTC())
                return -1;
            else
                return 0;
        }
    }
}
