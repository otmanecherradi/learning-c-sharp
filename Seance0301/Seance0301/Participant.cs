using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0301
{
    class Participant : Individu
    {
        private static int NbrParticipants = 0;

        private string section;
        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        private int nbrAbs;
        public int NbrAbs
        {
            get { return nbrAbs; }
            set { nbrAbs = value; }
        }

        public Participant() : base()
        {
            NbrParticipants += 1;

            Section = "Inconnu";
            NbrAbs = 0;
        }

        public Participant(int c, string n, string p, string s, int nbAb) : base(c, n, p)
        {
            NbrParticipants += 1;

            Section = s;
            NbrAbs = nbAb;
        }

        public void IncAbsence()
        {
            NbrAbs += 1;
        }

        public static int Nbre_Participants()
        {
            return NbrParticipants;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Participant {{\n\tCode = {Code};\n\tNom {Nom};\n\tPrenom = {Prenom};\n\tSection = {Section};\n\tNbrAbs = {NbrAbs};\n}}\n");
        }

    }
}
