using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice18
{
    internal class Exercice18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre entier");
            int Nombre = int.Parse(Console.ReadLine()); // stock le nombre demander
            int Operateur = 1; // iniatilise l'operateur à 1
            while (Operateur <= 10) // tant que l'operateur est <= 10 boucle
            {
                int Somme = Nombre * Operateur; // calcule la somme du nombre et de l'operateur actuel
                Console.WriteLine(Nombre + " * " + Operateur + " = " + Somme);
                Operateur = Operateur + 1; // ajoute 1 à l'operateur
            }
            Console.ReadLine();


        }
    }
}
