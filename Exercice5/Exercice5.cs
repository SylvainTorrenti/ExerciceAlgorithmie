using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    internal class Exercice5
    {
        static void Main(string[] args)
        {
            char c1 = 'a'; // inititialisation de c1
            char c2 = 'b'; // inititialisation de c2
            Console.WriteLine("La valeur initiale de c1 est " + c1);
            Console.WriteLine("La valeur initiale de c2 est " + c2);
            char c3 = c1; // stockage de la valeur de c1
            c1 = c2; // permutation de la valeur de c2 dans c1
            c2 = c3; // permutation de la valeur initiale de c1 stocker dans c2

            Console.WriteLine("La valeur permuter de c1 est " + c1);
            Console.WriteLine("La valeur permuter de c2 est " + c2);

            Console.ReadLine();

        }
    }
}
