using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;


namespace Seance0415_biz
{
    class DonnerManagement
    {
        public List<Donner> Donners;

        public DonnerManagement()
        {
            Donners = new List<Donner>();
        }

        private int InnerSearch(string cin)
        {
            int idx = -1;
            foreach (Donner d in Donners)
                if (d.CIN.Equals(cin))
                    idx = Donners.IndexOf(d);
            return idx;
        }

        public void Add(Donner d)
        {
            int idx = InnerSearch(d.CIN);
            if (idx != -1)
                throw new Exception("Deja dans la liste");
            Donners.Add(d);
        }

        public Donner Search(string cin)
        {
            int idx = InnerSearch(cin);
            if (idx == -1)
                throw new Exception("Introuvable");
            return Donners[idx];
        }

        public void Update(string cin, Donner newDonner)
        {
            int idx = InnerSearch(cin);
            if (idx == -1)
                throw new Exception("Introuvable");
            Donners[idx] = newDonner;
        }

        public void Remove(string cin)
        {
            int idx = InnerSearch(cin);
            if (idx == -1)
                throw new Exception("Introuvable");
            Donners.RemoveAt(idx);
        }

        public void SaveToXML()
        {
            StreamWriter sw = new StreamWriter("donneurs.dat");

            XmlSerializer xml = new XmlSerializer(Donners.GetType());
            xml.Serialize(sw, Donners);

            sw.Close();
        }
    }
}
