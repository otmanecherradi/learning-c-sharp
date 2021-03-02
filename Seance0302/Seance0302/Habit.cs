using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0302
{
    // Exam 2015
    class Habit : Article
    {
        private double taille;
        private string couleur;

        public Habit(int n, double p, int qs, int qm, double t, string c) : base(n, p, qs, qm)
        {
            taille = t;
            couleur = c;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumSerie = {numSerie};\n\tPrixHT = {prixHT};\n\tQtyStock = {qtyStock};\n\tQtyMinimal = {qtyMinimal};\n\tTaille = {taille};\n\tCouleur = {couleur};\n}}\n";
        }
    }
}
