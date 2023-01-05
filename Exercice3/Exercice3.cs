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
            bool ParseOK;
            int Rayon;
            do
            {
                Console.WriteLine("Entrez le rayon du cercle");
                ParseOK = int.TryParse(Console.ReadLine(), out Rayon); // Convertit le rayon de String a Int
            } while (ParseOK == false);
            int Diametre = Rayon * 2; // Calcul le diamétre
            double Perimetre = Diametre * Math.PI; // Calcul le perimetre
            Console.WriteLine("Le cercle de rayon " + Rayon + " a un périmétre égal à " + Perimetre); // affiche le resultat
            Console.ReadLine();
        }
    }
}
