using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    internal class Exercice11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecrivez un caractére");
            string caractere = Console.ReadLine();
            if ((caractere == "o") || (caractere == "O"))
            {
                Console.WriteLine("affirmatif");

            }
            if ((caractere == "n") || (caractere == "N"))
            {
                Console.WriteLine("négatif");
            }
            

                Console.ReadLine();
        }
    }
}
