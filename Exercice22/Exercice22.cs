using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice22
{
    internal class Exercice22
    {
        static void Main(string[] args)
        {
            int Nombre = 1;
            string Fizz = "Fizz";
            string Buzz = "Buzz";
            string FizzBuzz = "FizzBuzz ";


            while (Nombre <= 100) // tant que Nombre est <= 100
            {
                int Modulo3 = Nombre % 3; // calcul le modulo 3 en fonction du nombre actuel
                int Modulo5 = Nombre % 5; // calcul le modulo 5 en fonction du nombre actuel
                if ((Modulo3 == 0) && (Modulo5 == 0)) // Verifie si le nmodulo 3 et 5 du nombre = 0
                {
                    Console.WriteLine(FizzBuzz);
                }
                else if (Modulo3 == 0) // sinon verifie si le modulo 3 = 0
                {
                    Console.WriteLine(Fizz);
                }
                else if (Modulo5 == 0)// sinon verifie si le modulo 5 = 0 
                {
                    Console.WriteLine(Buzz);
                }
                else if (!(Modulo3 == 0) && !(Modulo5 == 0)) // sinon verifie si le modulo 3 != 0 et le modulo 5 != 0
                {
                    Console.WriteLine(Nombre);
                }
                Nombre = Nombre + 1;
            }
            Console.ReadLine();
        }
    }
}
