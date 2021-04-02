using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml.Serialization;

namespace Seance0402
{
    class TChambre
    {
        string txtFileName = "hotel.txt";
        string xmlFileName = "hotel.xml";

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
        public void SaveToFile()
        {
            StreamWriter sw = new StreamWriter(txtFileName, true);
            foreach (Chambre chambre in listChambre)
                sw.WriteLine(string.Join(';', chambre.Numero, chambre.Category, chambre.Prix));
            sw.Close();
        }
        public void ShowFromFile()
        {
            StreamReader sr = new StreamReader(txtFileName);
            while (sr.Peek() != -1)
            {
                string[] s = sr.ReadLine().Split(";");
                Console.WriteLine("Numero => {0}", s[0]);
                Console.WriteLine("Category => {0}", s[1]);
                Console.WriteLine("Prix => {0}", s[2]);
            }
            sr.Close();
        }
        public void SerializeToFile()
        {
            StreamWriter sw = new StreamWriter(xmlFileName, true);
            XmlSerializer xml = new XmlSerializer(listChambre.GetType());
            xml.Serialize(sw, listChambre);
            sw.Close();
        }
        public void DeserializeFromFile()
        {
            StreamReader sr = new StreamReader(txtFileName);
            XmlSerializer xml = new XmlSerializer(listChambre.GetType());
            xml.Deserialize(sr);
            sr.Close();
        }
    }
}
