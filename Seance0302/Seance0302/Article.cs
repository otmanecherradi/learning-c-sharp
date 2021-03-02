using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0302
{
    // Exam 2015

    class Article
    {

        // if asked for getters and setters, we use private/public approch, else we use protected as the following
        protected int numSerie;
        protected double prixHT;
        protected int qtyStock;
        protected int qtyMinimal;

        public Article() { }

        public Article(int n, double p, int qs, int qm) {
            numSerie = n;
            prixHT = p;
            qtyStock = qs;
            qtyMinimal = qm;
        }

        public void Sapprovisionner(int qty)
        {
            qtyStock += qty;
        }

        public void Achat(int qty)
        {
            qtyStock -= qty;

            if (qtyStock < qtyMinimal)
                Console.WriteLine("Nouvelle quantite inferieur au quantite minimum");
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumSerie = {numSerie};\n\tPrixHT = {prixHT};\n\tQtyStock = {qtyStock};\n\tQtyMinimal = {qtyMinimal};\n}}\n";
        }
    }
}
