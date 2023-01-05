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
            bool ParseOK;
            int Nombre;
            do
            {
                Console.WriteLine("Entrez un nombre");
                ParseOK = int.TryParse(Console.ReadLine(), out Nombre);
            } while (ParseOK == false);


            int modulo = Nombre % 2; // Calcul du modulo
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
