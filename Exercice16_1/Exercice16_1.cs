using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice16_1
{
    internal class Exercice16_1
    {
        static void Main(string[] args)
        {
            int Somme = 0;
            Console.WriteLine("Entrez un nombre");
            int Nombre = int.Parse(Console.ReadLine());
            while (Nombre > 0)
            {
                Somme = Nombre + Somme;
                Nombre = Nombre - 1;
            }
            Console.WriteLine("La somme est de " + Somme);
            Console.ReadLine();
        }
    }
}
