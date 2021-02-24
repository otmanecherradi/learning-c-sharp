using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0224
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
                if (description == "")
                    return "mon saisie";
                else
                    return description;
            }
            set
            {
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

        private DateTime dateAchat;
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
        
        public Produit(int c, string d, double p)
        {
            code = c;
            description = d;
            prixHT = p;
            dateAchat = DateTime.Now;
        }

        public double PrixTTC(double tva)
        {
            return prixHT + (prixHT * tva);
        }

        public void Affiche()
        {
            Console.WriteLine($"Produit {{\n\tCode = {code};\n\tDescription {description};\n\tPrixHT = {prixHT};\n\tPrixTTC = {PrixTTC(.2)};\n}}\n");
        }

        public int ComparerPrix(Produit p)
        {
            if (PrixTTC(.2) > p.PrixTTC(.2))
                return 1;
            else if (PrixTTC(.2) < p.PrixTTC(.2))
                return -1;
            else
                return 0;
        }
    }
}
