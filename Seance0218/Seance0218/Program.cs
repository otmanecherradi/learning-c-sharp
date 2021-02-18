using System;
using System.Text;

namespace Seance0218
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chiane de caractere

            // isUpper, detects if char is upspercase
            Console.WriteLine(char.IsUpper('G'));

            // isUpper, detects if char is upspercase
            Console.WriteLine(char.IsUpper('G'));

            // isDigit, detects if char is digit
            Console.WriteLine(char.IsDigit('2'));

            // IndexOf, returns the first index of sub string
            string str = "hello world";
            Console.WriteLine(str.IndexOf("lo"));

            int i = 0;
            while ((i = str.IndexOf('l', i)) != -1)
            {
                // subString, returns the string from the index specified until the end
                Console.WriteLine(str[i..]);
                Console.WriteLine(str.Substring(i));
                i += 1;
            }

            // StringBuilder
            StringBuilder s = new StringBuilder();

            for (int j = 0; j < 10; j += 1)
            {
                s.Append(j).Append(' ').AppendLine();
            }

            Console.WriteLine(s);


            Console.WriteLine("\n-------------------------------------------------------\n");

            // Exercice d'application

            // # Exercice 1 #
            Console.WriteLine("# Exercice 1 #");
            Console.Write("Donnez une phrase: > ");
            string p = Console.ReadLine();

            Console.WriteLine("la premier lettre est : {0}", char.IsUpper(p[0]) ? "majuscule" : "minuscule");
            Console.WriteLine("la phrase se termine avec un point : {0}", p.EndsWith('.'));
            Console.WriteLine("la nombre de mots dans la phrase : {0}", p.Split(' ').Length);
            Console.WriteLine("la nombre de caracteres dans la phrase : {0}", p.Length);
            int cmp = 0;
            i = 0;
            while ((i = p.IndexOf(' ', i)) != -1)
            {
                cmp += 1;
                i += 1;
            }
            Console.WriteLine("la nombre d'espace dans la phrase : {0}", cmp);
            // alternative
            Console.WriteLine("la nombre d'espace dans la phrase : {0}", p.Split(' ').Length - 1);

            Console.WriteLine("\n-------------------------------------------------------\n");

            // # Exercice 2 #
            Console.WriteLine("# Exercice 2 #");
            Console.Write("Donnez 5 mots separe par des espaces: > ");
            string motsSring = Console.ReadLine().Trim();
            var mots = motsSring.Split(' ');
            string v1 = mots[0];
            string v2 = mots[1];
            string v3 = mots[2];
            string v4 = mots[3];
            string v5 = mots[4];
            // alternate
            Array.Reverse(mots);
            foreach (var v in mots)
            {
                Console.WriteLine(v);
            }


            Console.WriteLine("\n-------------------------------------------------------\n");

            // # Exercice 5.1 #
            Console.WriteLine("# Exercice 5.1 #");
            Console.Write("Donnez une phrase: > ");
            string ex51ph = Console.ReadLine().Trim();
            
            Console.WriteLine("le nombre de caractere dans la chaine est: {0}", ex51ph.Split("").Length);

            Console.WriteLine("\n-------------------------------------------------------\n");

            // # Exercice 5.2 #
            Console.WriteLine("# Exercice 5.2 #");
            Console.Write("Donnez une phrase: > ");
            string ex52ph = Console.ReadLine().Trim();
            Console.WriteLine("les caracteres de la chaine sont:");
            foreach (var v in ex52ph.Split(" "))
            {
                Console.WriteLine(v);
            }
        }
    }
}
