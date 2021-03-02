using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0302
{
    class Electromenager : Article
    {
        private double poid;
        // dure de garantie exprimee en mois
        private int dureGarantie;

        public Electromenager(int n, double p, int qs, int qm, double pd, int d) : base(n, p, qs, qm)
        {
            poid = pd;
            dureGarantie = d;
        }

        public DateTime DateFinGarantie()
        {
            return DateTime.Now.AddMonths(dureGarantie);
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumSerie = {numSerie};\n\tPrixHT = {prixHT};\n\tQtyStock = {qtyStock};\n\tQtyMinimal = {qtyMinimal};\n\tPoid = {poid};\n\tDureGarantie = {dureGarantie};\n}}\n";
        }
    }
}
