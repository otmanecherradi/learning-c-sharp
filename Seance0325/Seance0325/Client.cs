using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0325
{
    class Client
    {
        private int numCli;
        public int NumCli { get => numCli; set => numCli = value; }

        private string nomCli;
        public string NomCli { get => nomCli; set => nomCli = value; }
        
        private string prenomCli;
        public string PrenomCli { get => prenomCli; set => prenomCli = value; }
        
        private string adrsCli;
        public string AdrsCli { get => adrsCli; set => adrsCli = value; }


        public Client() { }

        public Client(int numCli, string nomCli, string prenomCli, string adrsCli)
        {
            NumCli = numCli;
            NomCli = nomCli;
            PrenomCli = prenomCli;
            AdrsCli = adrsCli;
        }


        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tNumCli = {NumCli}\n\tNomCli = {NomCli}\n\tPrenomCli = {PrenomCli}\n\tAdrsCli= {AdrsCli}\n}}";
        }
    }
}
