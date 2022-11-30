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
            String Nombre1 = Console.ReadLine();
            int Nombre1Entier = int.Parse(Nombre1);
            Console.WriteLine("Entrez un deuxiéme nombre");
            string Nombre2 = Console.ReadLine();
            int Nombre2Entier = int.Parse(Nombre2);
            if (Nombre1Entier > Nombre2Entier)
            {
                Console.WriteLine("Le premier nombre est plus grand " + Nombre1Entier);
            }
            else
            {
                Console.WriteLine("Le second nombre est plus grand " + Nombre2Entier);
            }
            Console.ReadLine();
        }
    }
}
