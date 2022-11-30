using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12_1
{
    internal class Exercice12_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez l'âge de l'enfant");
            string Age = Console.ReadLine();
            int AgeConvertit = int.Parse(Age);

            if ((AgeConvertit >= 6) && (AgeConvertit <= 7))
            {
                Console.WriteLine("Poussin");
            }
            else if (AgeConvertit <= 9)
            {
                Console.WriteLine("Pupille");
            }
            else if (AgeConvertit <= 11)
            {
                Console.WriteLine("Minime");
            }
            else if (AgeConvertit >= 12)
            {
                Console.WriteLine("Cadet");
            }
            else if (AgeConvertit < 6)
            {
                Console.WriteLine("L'enfant est trop jeune");
            }


            Console.ReadLine();

        }
    }
}
