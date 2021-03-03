using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0303
{
    // Exam 2015
    class Electromenager : Article
    {
        private double poids;
        // dure de garantie exprimee en mois
        private int dureeGarantie;

        public Electromenager(int n, double p, int qs, int qm, double pd, int d) : base(n, p, qs, qm)
        {
            poids = pd;
            dureeGarantie = d;
        }

        public DateTime DateFinGarantie()
        {
            return DateTime.Now.AddMonths(dureeGarantie);
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumSerie = {numSerie};\n\tPrixHT = {prixHT};\n\tQtyStock = {qtyStock};\n\tQtyMinimal = {qtyMinimal};\n\tPoid = {poids};\n\tDureGarantie = {dureeGarantie};\n\tDateFinGarantie = {DateFinGarantie():G};\n}}\n";
        }
    }
}
