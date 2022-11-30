using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12
{
    internal class Exercice12
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
            if ((AgeConvertit >= 8) && (AgeConvertit <= 9))
            {
                Console.WriteLine("Pupille");
            }
            if ((AgeConvertit >= 10) && (AgeConvertit <= 11))
            {
                Console.WriteLine("Minime");
            }
            if (AgeConvertit >= 12) 
            {
                Console.WriteLine("Cadet");
            }
            if (AgeConvertit < 6)
            {
                Console.WriteLine("L'enfant est trop jeune");
            }
            Console.ReadLine();
        }
    }
}
