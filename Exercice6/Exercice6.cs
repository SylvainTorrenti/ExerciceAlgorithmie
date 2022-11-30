using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class Exercice6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            string Nombre = Console.ReadLine(); // stockage du nombre en string
            int NombreEntier = int.Parse(Nombre); // transformation du type string en int
            int modulo = NombreEntier % 2; // Calcul du modulo
            if (modulo == 0) // si le modulo = 0 le chiffre et pair
            {
                Console.WriteLine("Le nombre est pair");
            }
            else // si le modulo != 0 le chiffre et pair
            {
                Console.WriteLine("Le nombre est impair");
            }
            Console.ReadLine();
        }
    }
}
