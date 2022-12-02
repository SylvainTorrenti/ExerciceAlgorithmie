using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice16
{
    internal class Exercice16
    {
        static void Main(string[] args)
        {
            int Somme = 0; //Initialise la Somme à 0
            int Nombre = 5; // Initialise le nombre à 5
            while (Nombre > 0) // tant que le nombre > 0 alors
            {
                Somme = Nombre + Somme; // caclcule la somme avec la valeur du nombre actuel + la somme actuelle
                Nombre = Nombre - 1; // enlêve 1 au nombrea actuel
            }
            Console.WriteLine("La somme est de " + Somme);
            Console.ReadLine();
        }

        
    }
}
