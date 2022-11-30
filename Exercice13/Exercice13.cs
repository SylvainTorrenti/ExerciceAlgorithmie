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
            string Age = Console.ReadLine(); // stock l'age
            Console.WriteLine("Indiquez votre sexe");
            string Sexe = Console.ReadLine(); // stock le sexe
            int AgeConvertit = int.Parse(Age); // convertit l'age en int

            if ((AgeConvertit > 20) && (Sexe == "homme")){ //verifie si l'age est superieur à 20 ans et si il s'agit d'un homme
                Console.WriteLine("Vous êtes imposable");
            }
            else if ((AgeConvertit >18 && AgeConvertit < 35) && (Sexe == "femme")) //verifie si l'age est compris entre 18 ans et 35 ans et si il s'agit d'une femme
            {
                Console.WriteLine("Vous ête imposable");
            }
            else // si aucune condition plus haut n'est verifié
            {
                Console.WriteLine("Vous n'êtes pas imposable");
            }

            Console.ReadLine(); 
        }
    }
}
