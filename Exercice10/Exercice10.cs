using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10
{
    internal class Exercice10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecrire un nombre");
            int Nombre1 = int.Parse(Console.ReadLine());// stock le 1er nombre
            Console.WriteLine("Ecrire un second nombre");
            int Nombre2 = int.Parse(Console.ReadLine());// stock le 2eme nombre


            if ((Nombre1 < 0) && (Nombre2 > 0)) // verifie si le 1er nombre est négatif et le 2eme positif
            {
                Console.WriteLine("Le produit est négatif");
            }
            else if ((Nombre2 < 0) && (Nombre1 > 0)) // verifie si le 2eme nombre est négatif et le 1er positif
            {
                Console.WriteLine("Le produit est négatif");
            }
            else // si aucune des deux condition se verifie
            {
                Console.WriteLine("Le produit est positif");
            }


                Console.ReadLine();

        }
    }
}
