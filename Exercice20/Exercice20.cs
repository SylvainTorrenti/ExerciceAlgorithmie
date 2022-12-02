using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20
{
    internal class Exercice20
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Entrez un nombre");
                int Nombre = int.Parse(Console.ReadLine());
                int Somme = 0; //Initialise la Somme à 0
                while (Nombre > 0) // tant que le nombre > 0 alors
                {
                    Somme = Nombre + Somme; // caclcule la somme avec la valeur du nombre actuel + la somme actuelle
                    Nombre = Nombre - 1; // enlêve 1 au nombrea actuel
                }
                Console.WriteLine("La somme est de " + Somme);
            }
            
                Console.WriteLine("Voulez vous fair un nouveau calcul? O/N");
                string Reponse = Console.ReadLine();
            

            while (Reponse == "O")
            {
                Console.WriteLine("Entrez un nombre");
                int Nombre = int.Parse(Console.ReadLine());
                int Somme = 0; //Initialise la Somme à 0
                while (Nombre > 0) // tant que le nombre > 0 alors
                {
                    Somme = Nombre + Somme; // caclcule la somme avec la valeur du nombre actuel + la somme actuelle
                    Nombre = Nombre - 1; // enlêve 1 au nombrea actuel
                }
                {
                    Console.WriteLine("La somme est de " + Somme);
                    Console.WriteLine("Voulez vous fair un nouveau calcul? O/N");
                    Reponse = Console.ReadLine();
                }



            }
            Console.ReadLine();
        }
    }
}
