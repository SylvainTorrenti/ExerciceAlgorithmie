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
            bool ParseOK;
            int Nombre1;
            int Nombre2;
            do
            {
                Console.WriteLine("Entrez un nombre");
                ParseOK = int.TryParse(Console.ReadLine(), out Nombre1); // Convertit le 1er nombre
            } while (ParseOK == false);
            do
            {
                Console.WriteLine("Entrez un deuxiéme nombre");
                ParseOK = int.TryParse(Console.ReadLine(), out Nombre2); //Convertit le 2eme nombre
            } while (ParseOK == false);

            if (Nombre1 > Nombre2) // Si le nombre 1 est plus grand
            {
                Console.WriteLine("Le premier nombre est plus grand ");
            }
            else // Si le nombre 2 est plus grand
            {
                Console.WriteLine("Le second nombre est plus grand ");
            }
            Console.ReadLine();
        }
    }
}
