using System;

namespace Seance0301
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seance march 1st

            //test of Individu, Animateur and Participant classes

            Individu I1 = new Individu(1, "Kamal", "Mohammed");
            Animateur I2 = new Animateur(2, "Lahlou", "Samir", "DESA", "Matematique");
            Participant I3 = new Participant(3, "Talal", "Aziz", "TDI", 5);

            I1.Afficher();
            I2.Afficher();
            I3.Afficher();

            I3.IncAbsence();
            I3.IncAbsence();

            I2.Specialite = "Physique";

            I1.Afficher();
            I2.Afficher();
            I3.Afficher();

            Console.WriteLine("Le nbr de participant: {0}", Participant.Nbre_Participants());

            Console.WriteLine("\n---------------------------------------------------------------\n");

            //test of Personne classe

            Personne p1 = new Personne("Kamal", "Mohammed", 12);
            Personne p2 = new Personne("Lahlou", "Samir", 22);

            Console.WriteLine("p1 => {0}", p1.SePresenter());
            Console.WriteLine("p2 => {0}", p2.SePresenter());

            //test of Chanteur classe

            Chanteur c1 = new Chanteur("Kamal", "Mohammed", 12);
            Chanteur c2 = new Chanteur("Lahlou", "Samir", 22);

            Console.WriteLine("c1 => {0}", c1.SePresenter());
            Console.WriteLine("c2 => {0}", c2.SePresenter());

            Console.WriteLine("nom de c1 => {0}", c1.GetNom());
            Console.WriteLine("nom de c2 => {0}", c2.GetNom());

            Console.WriteLine("profession de c1 => {0}", c1.GetProfession());
            Console.WriteLine("profession de c2 => {0}", c2.GetProfession());



        }
    }
}
