using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice19
{
    internal class Exercice19
    {
        static void Main(string[] args)
        {
            int Somme = 1; // Initialise la somme à 1
            Console.WriteLine("Entrez un nombre");
            int Nombre = int.Parse(Console.ReadLine()); // stock le nombre demandé
            while (Nombre > 0) //Boucle tant que le nombre est positif
            {
                Somme = Nombre * Somme; // calcul la somme en aditionnant le nombre actuel et la somme actuel
                Nombre = Nombre - 1; // retir 1 au nombre actuel
            }
            Console.WriteLine("La somme est de " + Somme);
            Console.ReadLine();
        }
    }
}
