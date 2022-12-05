using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercice21_1
{
    internal class Exercice21_1
    {
        static void Main(string[] args)
        {
            string Mois;
            Regex Var = new Regex("^[1-9]$|^1[0-2]"); // definit la regex
            Console.WriteLine("Entrez un numero de mois");
            Mois = Console.ReadLine(); // stock le mois
            while (true)
            {
                if (Var.IsMatch(Mois)) // verifie si le mois match avec la regex
                {
                    Console.WriteLine("Vous avez entrez " + Mois);
                    Console.WriteLine("Entrez un nouveau mois");
                    Mois = Console.ReadLine();
                }               
                else
                {
                    Console.WriteLine("Vous avez rentrez une mauvaise donnée!");
                    Console.WriteLine("Entrez un mois valide!");
                    Mois = Console.ReadLine();
                }

            }
            Console.ReadLine();
        }
    }
}
