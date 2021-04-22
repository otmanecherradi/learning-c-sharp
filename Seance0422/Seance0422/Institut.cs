using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0422
{
    class Institut
    {

        List<Stagiaire> Stagiaires { get; set; }

        public Institut()
        {
            Stagiaires = new List<Stagiaire>();
        }

        public void Add(Stagiaire s)
        {
            Stagiaires.Add(s);
        }

        public Stagiaire Search(int id)
        {
            int idx = SearchById(id);
            if (idx != -1)
                return Stagiaires[idx];

            throw new Exception("Inexistant");
        }

        public void Update(int id, Stagiaire s)
        {
            int idx = SearchById(id);
            if (idx != -1)
            {
                Stagiaires[idx].Nom = s.Nom;
                Stagiaires[idx].Prenom = s.Prenom;
                Stagiaires[idx].Sexe = s.Sexe;
                Stagiaires[idx].DateNaissance = s.DateNaissance;
                Stagiaires[idx].Module = s.Module;
                Stagiaires[idx].Note = s.Note;

            }

            throw new Exception("Inexistant");
        }

        public void Delete(int id)
        {
            int idx = SearchById(id);
            if (idx != -1)
                Stagiaires.RemoveAt(idx);

            throw new Exception("Inexistant");
        }

        private int SearchById(int id)
        {
            foreach (Stagiaire s in Stagiaires)
                if (s.Numero.Equals(id))
                    return Stagiaires.IndexOf(s);

            return -1;
        }

    }
}
