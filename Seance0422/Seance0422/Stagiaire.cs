using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0422
{

    public enum SexeEnum
    {
        Feminin = 'f',
        Masculin = 'm',
    }

    public class Stagiaire
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public SexeEnum Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Module { get; set; }
        public double Note { get; set; }

        public Stagiaire() { }

        public Stagiaire(int numero, string nom, string prenom, SexeEnum sexe, DateTime dateNaissance, int module, double note)
        {
            Numero = numero;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            DateNaissance = dateNaissance;
            Module = module;
            Note = note;
        }
    }
}
