using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0301
{
    class MainsonEdition
    {
        private string nom;
        // not sure about this one fro now
        private List<Chanteur> chanteurs;

        public void SetNom(string n) { nom = n; }
        public string GetNom() { return nom; }

        public void SetChnateurs(List<Chanteur> c) { chanteurs = c; }
        public List<Chanteur> GetChanteur() { return chanteurs; }

        public void AddSinger(Chanteur c)
        {
            chanteurs.Add(c);
        }

        public void AddSingers(List<Chanteur> cs)
        {
            foreach (Chanteur c in cs)
            {
                chanteurs.Add(c);
            }
        }
    }
}
