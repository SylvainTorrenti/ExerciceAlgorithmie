using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    internal class Exercice7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            String Nombre1 = Console.ReadLine(); //Stock le 1er nombre
            int Nombre1Entier = int.Parse(Nombre1); // Convertit le 1er nombre
            Console.WriteLine("Entrez un deuxiéme nombre");
            string Nombre2 = Console.ReadLine(); //Stock le 2eme nombre
            int Nombre2Entier = int.Parse(Nombre2); //Convertit le 2eme nombre
            if (Nombre1Entier > Nombre2Entier) // Si le nombre 1 est plus grand
            {
                Console.WriteLine("Le premier nombre est plus grand " + Nombre1Entier);
            }
            else // Si le nombre 2 est plus grand
            {
                Console.WriteLine("Le second nombre est plus grand " + Nombre2Entier);
            }
            Console.ReadLine();
        }
    }
}
