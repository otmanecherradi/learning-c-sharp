using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0401
{
    abstract class Article
    {
        public string Marque { get; set; }
        public double PrixUnitaire { get; set; }

        protected Article(string marque, double prixUnitaire)
        {
            Marque = marque;
            PrixUnitaire = prixUnitaire;
        }
    }
}
