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

            if ((AgeConvertit >= 6) && (AgeConvertit <= 7)) //Verifie si l'age est compris entre 6 et 7 ans
            {
                Console.WriteLine("Poussin");
            }
            else if (AgeConvertit <= 9) //Si la condition precedente est fausse verifie si l'age est inferieur à 9 ans
            {
                Console.WriteLine("Pupille");
            }
            else if (AgeConvertit <= 11) //Si la condition precedente est fausse verifie si l'age est inferieur à 11 ans
            {
                Console.WriteLine("Minime");
            }
            else if (AgeConvertit >= 12) //Si la condition precedente est fausse verifie si l'age est inferieur à 12 ans
            {
                Console.WriteLine("Cadet");
            }
            else if (AgeConvertit < 6) //Si la condition precedente est fausse verifie si l'age est inferieur à 6 ans
            {
                Console.WriteLine("L'enfant est trop jeune");
            }


            Console.ReadLine();

        }
    }
}
