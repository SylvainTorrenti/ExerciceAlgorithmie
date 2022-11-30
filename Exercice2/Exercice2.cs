using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Exercice2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez un nombre"); 
            string Nombre = Console.ReadLine(); // stock l'entrée en string
            int NombreEntier = int.Parse(Nombre); // Transforme le string en int
            int NombreCube = NombreEntier * NombreEntier * NombreEntier; // Calcul du cube

            Console.WriteLine("Le nombre au cube est " + NombreCube); // affichage du cube

            Console.ReadLine();
        }
    }
}
