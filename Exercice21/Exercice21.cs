using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice21
{
    internal class Exercice21
    {
        static void Main(string[] args)
        {
            String Mois;
            string Regex = "^[1-9]$|^1[0-2]";
            Console.WriteLine("Entrez un numero de mois");
            Mois = Console.ReadLine();

            if (Mois != Regex)
            {
                Console.WriteLine("Vous avez renrez une mauvaise donnée!");
            }
            
        }
    }
}
