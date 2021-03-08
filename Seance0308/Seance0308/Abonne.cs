namespace Seance0308
{
    class Abonne
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string phoneNum;
        public string PhoneNumber
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }


        public Abonne() { }

        public Abonne(string n, string nb)
        {
            nom = n;
            phoneNum = nb;
        }


        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNom = {Nom};\n\tPhoneNumber = {PhoneNumber};\n}}\n";
        }
    }
}
