using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_1
{
    internal class Exercice1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom:");
            string Nom = Console.ReadLine(); // stock le nom
            Console.WriteLine("Entrez votre age:");
            string age = Console.ReadLine(); // stock l'age
            Console.WriteLine($"Bonjour {Nom} tu as {age} ans"); // affiche le nom et l'âge

            Console.ReadLine();
        }
    }
}
