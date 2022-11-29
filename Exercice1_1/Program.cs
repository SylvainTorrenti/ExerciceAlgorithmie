using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom:");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre age:");
            string age = Console.ReadLine();
            Console.WriteLine("bonjour " + nom + " tu as " + age + " ans");

            Console.ReadLine();
        }
    }
}
