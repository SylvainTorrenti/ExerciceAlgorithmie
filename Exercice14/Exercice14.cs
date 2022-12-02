using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice14
{
    internal class Exercice14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nombre de photocopies faites");
            int NbPhotocopies = int.Parse(Console.ReadLine()); //Stock le nombre de photocopie
            double Prix1 = 1; // donne le prix des 10 premiére photocopies
            double Prix2 = 1.9; // donne le prix des 10 suivantes

            if (NbPhotocopies <= 10) // verifie si le nombre de photocopie est <= 10
            {
                double PremierPrix = NbPhotocopies * 0.1; // calcul le prix des photocpies
                Console.WriteLine("la facture est de " + PremierPrix);

            }
            if ((NbPhotocopies > 10) && (NbPhotocopies <= 20)) // verifie si le nombre de photocopie est entre 10 et 20
            {
                int PhotocopieDeux = NbPhotocopies - 10; // enléve les 10 premiére photocopies
                double DeuxiemePrix = (PhotocopieDeux * 0.09) + Prix1; // calcul le prix des photocopie comprisent entre 10 et 20 et ajoute le prix des 10 premiéres
                Console.WriteLine("La facture est de " + DeuxiemePrix);
            }
            if (NbPhotocopies > 20) // verifie si le nombre de photocopie est > 20
            {
                int PhotocopieTrois = NbPhotocopies - 20; // enléve les 20 premiére photocopies
                double Troisiemeprix = (PhotocopieTrois * 0.08) + Prix2; // calcul le prix des photocopie superieur à 20 et ajoute le prix des 20 premiéres
                Console.WriteLine("La facture est de " + Troisiemeprix);
            }

            Console.ReadLine();
        }
    }
}
