using System;

namespace Seance0401
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance April 1st

            // Continuing Intercafes


            // test for BasicCar and BasicTruck
            BasicCar dacia = new BasicCar();
            dacia.setColor("Red");
            dacia.setWheelCount(5);
            dacia.changeGear(3);
            dacia.speedUp(100);

            BasicTruck man = new BasicTruck();
            man.LoadType = "vide";


            // test of Personne
            Personne p = new Personne("kamal", "yahya");
            p.afficher();
            // appelle via une reference d'interface
            // copy the object to another object via a interface
            IAffichable a = (p as IAffichable);
            a.afficher();

        }
    }
}
