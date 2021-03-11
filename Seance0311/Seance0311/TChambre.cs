using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0311
{
    class TChambre
    {
        List<Chambre> listChambre;
        public List<Chambre> ListChambre { get => listChambre; set => listChambre = value; }


        public TChambre()
        {
            listChambre = new List<Chambre>();
        }


        public void Create(Chambre c) => listChambre.Add(c);
        public int Search(int num)
        {
            int idx = -1;
            for (int i = 0; i < listChambre.Count; i += 1)
                if (listChambre[i].Numero.Equals(num))
                {
                    idx = i;
                    break;
                }
            return idx;
        }
        public void Delete(int num)
        {
            int idx = Search(num);
            if (idx == -1)
                Console.WriteLine("Chambre Introuvable");
            else
                listChambre.RemoveAt(idx);
        }
        public void ListChamberOfCategory(int ctg)
        {
            foreach (Chambre chambre in listChambre)
                if (chambre.Category.Equals(ctg))
                    chambre.Affiche_Chambre();
        }
        public bool ReserveChamber(int num)
        {
            bool r = false;
            foreach (Chambre chambre in listChambre)
                if (chambre.Numero.Equals(num))
                    if (chambre.Etat == 'L')
                    {
                        chambre.Etat = 'O';
                        r = true;
                    }
                    else
                        Console.WriteLine("La chambre est Occupee");
            return r;
        }
        public List<Chambre> ListChambersSortedByCapacity()
        {
            List<Chambre> nl = listChambre;
            nl.Sort((Chambre a1, Chambre a2) => a1.Capacity.CompareTo(a2.Capacity));
            return nl;
        }
    }
}
