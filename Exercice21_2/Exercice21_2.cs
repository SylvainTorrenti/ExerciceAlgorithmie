using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercice21_2
{
    internal class Exercice21_2
    {
        static void Main(string[] args)
        {
            string Mois;
            Regex Var = new Regex("^[1-9]$|^1[0-2]");
            Console.WriteLine("Entrez un numero de mois");
            Mois = Console.ReadLine();
            if (true)
            {
                if (!(Var.IsMatch(Mois)))
                {
                    Console.WriteLine("Vous avez rentrez une mauvaise donnée!");
                    Console.WriteLine("Entrez un mois valide!");
                    Mois = Console.ReadLine();
                }
                do
                {
                    Console.WriteLine("Vous avez entrez " + Mois);
                    Console.WriteLine("Entrez un nouveau mois");
                    Mois = Console.ReadLine();
                    if (!(Var.IsMatch(Mois)))
                    {
                        Console.WriteLine("Vous avez rentrez une mauvaise donnée!");
                        Console.WriteLine("Entrez un mois valide!");
                        Mois = Console.ReadLine();
                    }
                } while (Var.IsMatch(Mois));
            }
            Console.ReadLine();
        }
    }
}
