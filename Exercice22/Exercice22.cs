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
            int Modulo3 = Nombre % 3;
            int Modulo5 = Nombre % 5;

            while (Nombre <= 100)
            {
                if (Modulo3 == 3)
                {
                    Console.WriteLine(Fizz);
                }
                if (Modulo5 == 5)
                {
                    Console.WriteLine(Buzz);
                }
                if ((Modulo3 == 3) && (Modulo5 == 5))
                {
                    Console.WriteLine(FizzBuzz);
                }
                else
                {
                    Console.WriteLine(Nombre);
                }
                Nombre = Nombre + 1;
            }
            Console.ReadLine();
        }
    }
}
