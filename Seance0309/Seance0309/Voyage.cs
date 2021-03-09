using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0309
{
    class Voyage
    {
        private static int nbrVoyages = 0;

        private int nbrVoyage;
        public int NbrVoyage
        {
            get { return nbrVoyage; }
            set { nbrVoyage = value; }
        }

        private Chauffeur vChauffeur;
        public Chauffeur VChauffeur
        {
            get { return vChauffeur; }
            set { vChauffeur = value; }
        }

        private Bus vBus;
        public Bus VBus
        {
            get { return vBus; }
            set { vBus = value; }
        }

        private DateTime vDate;
        public DateTime VDate
        {
            get { return vDate; }
            set { vDate = value; }
        }

        private string villeDepart;
        public string VilleDepart
        {
            get { return villeDepart; }
            set { villeDepart = value; }
        }

        private string villeArrive;
        public string VilleArrive
        {
            get { return villeArrive; }
            set { villeArrive = value; }
        }

        private int nbrVoyageurs;
        public int NbrVoyageurs
        {
            get { return nbrVoyageurs; }
            set { nbrVoyageurs = value; }
        }

        private double prixBillet;
        public double PrixBillet
        {
            get { return prixBillet; }
            set { prixBillet = value; }
        }


        public Voyage()
        {
            nbrVoyages += 1;
            nbrVoyage = nbrVoyages;
            vDate = DateTime.Now;
        }

        public Voyage(Chauffeur c, Bus b, string vd, string va, int vs, double pb) : this()
        {
            vChauffeur = c;
            vBus = b;
            villeDepart = vd;
            villeArrive = va;
            nbrVoyageurs = vs;
            prixBillet = pb;
        }


        public override string ToString()
        {
            //return $"{GetType().Name} {{\n\tNbrVoyage = {NbrVoyage};\n\tVChauffeur = {VChauffeur};\n\tVBus = {VBus};\n\tVDate = {VDate};\n\tVilleDepart = {VilleDepart};\n\tVilleArrive = {VilleArrive};\n\tBbrVoyageurs = {BbrVoyageurs};\n\tPrixBillet = {PrixBillet};\n}}\n";

            return $"{NbrVoyage}\t{VChauffeur}\t{VBus}\t{VDate}\t{VilleDepart}\t{VilleArrive}\t{NbrVoyageurs}\t{PrixBillet * nbrVoyages}";
        }
    }
}
