﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    internal class Exercice8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un entier");
            string Entier = Console.ReadLine();
            int EntierConvertit = int.Parse(Entier);
            if(EntierConvertit > 0 )
            {
                Console.WriteLine("Le nombre est positif");
            }
            if (EntierConvertit < 0)
            {
                Console.WriteLine("Le nombre est négatif");
            }
            if (EntierConvertit == 0)
            {
                Console.WriteLine("Le nombre est 0");
            }

            Console.ReadLine();
        }
    }
}
