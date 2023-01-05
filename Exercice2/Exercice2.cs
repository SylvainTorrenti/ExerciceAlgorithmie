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
            bool ParseOK;
            int Nombre;
            do
            {
                Console.WriteLine("Rentrez un nombre");
                ParseOK = int.TryParse(Console.ReadLine(),out Nombre); // Transforme le string en int
            } while (ParseOK==false);
           
            int NombreCube = Nombre * Nombre * Nombre; // Calcul du cube

            Console.WriteLine($"Le nombre au cube est {NombreCube}"); // affichage du cube

            Console.ReadLine();
        }
    }
}
