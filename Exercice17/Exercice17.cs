using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice17
{
    internal class Exercice17
    {
        static void Main(string[] args)
        {
            int Somme = 0; // initialise la somme à 0
            Console.WriteLine("Entrez un nombre");
            int Nombre = int.Parse(Console.ReadLine()); // stock le nombre demandé

            while (Nombre > 0) // tant que le nombre est > 0 boucle
            {
                int Modulo = Nombre % 2; // calcul le modulo du nombre actuel
                if (Modulo == 0) // si le modulo = 0
                {
                    Somme = Nombre + Somme; //calcul la somme en adiotonnant le nombre et la somme actuelle
                    Nombre = Nombre - 1; // enléve 1 au nombre
                }
                else // si le modulo est egale a 1
                {
                    Nombre = Nombre - 1; // enleve 1 au nombre
                }
            }
            Console.WriteLine("La somme des pairs est " + Somme);

            Console.ReadLine();
        }
    }
}
