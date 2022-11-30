using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13
{
    internal class Exercice13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indiquez votre age");
            string Age = Console.ReadLine();
            Console.WriteLine("Indiquez votre sexe");
            string Sexe = Console.ReadLine();
            int AgeConvertit = int.Parse(Age);

            if ((AgeConvertit > 20) && (Sexe == "homme")){
                Console.WriteLine("Vous êtes imposable");
            }
            else if ((AgeConvertit >18 && AgeConvertit < 35) && (Sexe == "femme"))
            {
                Console.WriteLine("Vous ête imposable");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas imposable");
            }

            Console.ReadLine(); 
        }
    }
}
