using System;
using System.Collections.Generic;
using System.Text;


namespace Seance0402
{
    [Serializable]
    class Etudiant
    {
        public int NumeroInscription { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Etudiant(int numeroInscription, string nom, string prenom)
        {
            NumeroInscription = numeroInscription;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return string.Join('\t', NumeroInscription, Nom, Prenom);
            //return $"{GetType().Name} {{\n\tId = {Id};\n\tTitle = {Title};\n\tDescription = {Description};\n\tDate = {Date};\n}}";
        }
    }
}
