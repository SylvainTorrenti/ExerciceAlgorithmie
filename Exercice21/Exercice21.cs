using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercice21
{
    internal class Exercice21
    {
        static void Main(string[] args)
        {
            string Mois;
            Regex Var = new Regex("^[1-9]$|^1[0-2]"); //definit la regex
            Console.WriteLine("Entrez un numero de mois");
            Mois = Console.ReadLine(); // stock le mois
            while (!(Var.IsMatch(Mois))) // tant que l'entré ne correpsond pas à la Regex
            {
                Console.WriteLine("Vous avez rentrez une mauvaise donnée!");
                Console.WriteLine("Entrez un mois valide!");
                Console.WriteLine("Entrez un nouveau mois");
                Mois = Console.ReadLine();
                Console.WriteLine("Vous avez entrez " + Mois);
            }
            Console.WriteLine("Vous avez entrez " + Mois);
            while (Var.IsMatch(Mois)) // tant que le mois correspond à la Regex
            {
                Console.WriteLine("Entrez un nouveau mois");
                Mois = Console.ReadLine();
                while (!(Var.IsMatch(Mois)))// tant que l'entré ne correpsond pas à la Regex
                {
                    Console.WriteLine("Vous avez rentrez une mauvaise donnée!");
                    Console.WriteLine("Entrez un mois valide!");
                    Mois = Console.ReadLine();
                }
                Console.WriteLine("Vous avez entrez " + Mois);
            }

            Console.ReadLine();
        }
    }
}
