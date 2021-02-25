using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0225
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
    }
}
