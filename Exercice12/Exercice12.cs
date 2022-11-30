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
            int AgeConvertit = int.Parse(Age); //Convertit l'age en int

            if ((AgeConvertit >= 6) && (AgeConvertit <= 7)) //Verifie si l'age est compris entre 6 et 7 ans
            {
                Console.WriteLine("Poussin");
            }
            if ((AgeConvertit >= 8) && (AgeConvertit <= 9)) //Verifie si l'age est compris entre 8 et 9 ans
            {
                Console.WriteLine("Pupille");
            }
            if ((AgeConvertit >= 10) && (AgeConvertit <= 11)) //Verifie si l'age est compris entre 10 et 11 ans
            {
                Console.WriteLine("Minime");
            }
            if (AgeConvertit >= 12) //Verifie si l'age est superieur à 12 ans
            {
                Console.WriteLine("Cadet");
            }
            if (AgeConvertit < 6) //Verifie si l'age est superieur à 6 ans
            {
                Console.WriteLine("L'enfant est trop jeune");
            }
            Console.ReadLine();
        }
    }
}
