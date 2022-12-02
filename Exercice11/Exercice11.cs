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
            string caractere = Console.ReadLine(); // stock le caractére
            if ((caractere == "o") || (caractere == "O")) // verifie si le caractére est "o" ou "O"
            {
                Console.WriteLine("affirmatif");

            } 
            else if ((caractere == "n") || (caractere == "N")) // verifie si le caractére est "n" ou "N"
            {
                Console.WriteLine("négatif");
            }
            else // si les autres condition ne se verifie pas
            {
                Console.WriteLine("???");
            }
            

                Console.ReadLine();
        }
    }
}
