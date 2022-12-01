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
            Console.WriteLine("Entré le nombre de photocopie faites");
            string Photocopie = Console.ReadLine();
            int PhotocopieConvertit = int.Parse(Photocopie);
            if (PhotocopieConvertit <= 10)
            {
                double PremierPrix = PhotocopieConvertit * 0.1;
                Console.WriteLine("la facture est de " + PremierPrix);

            }


            if ((PhotocopieConvertit > 10) && (PhotocopieConvertit <= 20))
            {
                int PhotocopieDeux = PhotocopieConvertit - 10;
                double DeuxiemePrix = (PhotocopieDeux * 0.09) + 1;
                Console.WriteLine("La facture est de " + DeuxiemePrix);
            }
            if (PhotocopieConvertit > 20)
            {
                int PhotocopieTrois = PhotocopieConvertit - 20;
                double Troisiemeprix = (PhotocopieTrois * 0.08) + 1.9;
                Console.WriteLine("La facture est de " + Troisiemeprix);
            }






            Console.ReadLine();
        }
    }
}
