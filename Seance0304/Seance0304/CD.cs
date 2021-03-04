using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0304
{
    // Add other genres as needed
    enum Genres
    {
        Rock,
        Pop,
        HardRock
    }

    class CD
    {

        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string titre;
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        private Genres genre;
        public Genres Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private DateTime dateEdition;
        public DateTime DateEdition
        {
            get { return dateEdition; }
            set { dateEdition = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public CD() { }
        public CD(int n, string t, Genres g, DateTime d, string a)
        {
            Numero = n;
            titre = t;
            Genre = g;
            DateEdition = d;
            Author = a;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumero = {Numero};\n\tTitre = {Titre};\n\tGenre = {Genre};\n\tDate Edition = {DateEdition};\n\tAuthor = {Author};\n}}\n";
        }
    }
}
