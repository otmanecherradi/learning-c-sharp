using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0302
{
    class Chanteur : Personne
    {
        private string maisonEdition = "";

        public Chanteur(string n, string p, int a) : base(n, p, a)
        {
            SetProfession("chanteur");
        }

        public void SetMaisonEdition(string m) { maisonEdition = m; }
        public string GetMaisonEdition() { return maisonEdition; }

        public override string SePresenter()
        {
            return $"{base.SePresenter()}, Je suis chanteur";
        }
    }
}
