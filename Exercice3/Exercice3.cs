using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Exercice3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le rayon du cercle");
            string Rayon = Console.ReadLine(); // Stock le rayon donné
            int RayonEntier = int.Parse(Rayon); // Convertit le rayon de String a Int
            int Diametre = RayonEntier * 2; // Calcul le diamétre
            double Perimetre = Diametre * Math.PI; // Calcul le perimetre
            Console.WriteLine("Le cercle de rayon " + Rayon + " a un périmétre égal à " + Perimetre); // affiche le resultat

            Console.ReadLine();
        }
    }
}
