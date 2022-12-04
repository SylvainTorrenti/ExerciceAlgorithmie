using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20_1
{
    internal class Exercice20_1
    {
        static void Main(string[] args)
        {
            int Nombre;
            int Resultat;
            string Reponse;
            {

                System.Console.WriteLine("Veuillez saisir un entier positif");

                Nombre = int.Parse(System.Console.ReadLine()); // stock le nombre

                Resultat = Somme(Nombre); // stock le resultat dans une variable
                Console.WriteLine("La somme est de " + Resultat);

                Console.WriteLine("Voulez vous faire un autre calcule? (O/N)");
                Reponse= System.Console.ReadLine();
                
            }
        }

        private static int Somme(int Nombre)
        {


            if (Nombre == 1) //si le nombre = 1

                return 1; // renvoie 1 comme resultat

            else // sinon

                return Nombre + Somme(Nombre - 1); // calcule la somme en ajoutant l'entier actuel

        }
    }
}
