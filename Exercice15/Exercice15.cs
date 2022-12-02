using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15
{
    internal class Exercice15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez vos années de permis");
            int Permis = int.Parse(Console.ReadLine());
            Console.WriteLine("Combien d'accident avez vous eu?");
            int Accident = int.Parse(Console.ReadLine());
            Console.WriteLine("Depuis combien d'années êtes vous parmis nous?");
            int Ancienete = int.Parse(Console.ReadLine());

            if (Age < 25)
            {
                if (Permis < 2)
                {
                    if (Accident > 0)
                    {
                        Console.WriteLine("Nous ne pouvons vous assurer");
                    }
                    else
                        Console.WriteLine("Vous êtes au tarif rouge");
                    if (Ancienete > 5)
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                    }
                }
                else
                {
                    if (Accident > 0)
                    {
                        Console.WriteLine("Vous êtes au tarif rouge");
                        if (Ancienete > 5)
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                        }
                    }
                    else
                        Console.WriteLine("Vous êtes au tarif Orange");
                    if (Ancienete > 5)
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Vert");
                    }
                }
            }
            else
            {
                if (Permis < 2)
                {
                    if (Accident > 0)
                    {
                        Console.WriteLine("Vous êtes au tarif rouge");
                        if (Ancienete > 5)
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                        }
                    }
                    else
                        Console.WriteLine("Vous êtes au tarif Orange");
                    if (Ancienete > 5)
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif vert");
                    }
                }
                else
                {
                    if (Accident > 2)
                    {
                        Console.WriteLine("Nous ne pouvons vous assurer");
                    }
                    else if ((Accident > 1) && (Accident <= 2))
                    {
                        Console.WriteLine("Vous êtes au tarif rouge");
                        if (Ancienete > 5)
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                        }
                    }
                    else if ((Accident > 0) && (Accident <= 1))
                    {
                        Console.WriteLine("Vous êtes au tarif Orange");
                        if (Ancienete > 5)
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Vert");
                        }
                    }
                    else
                        Console.WriteLine("Vous êtes au tarif Vert");
                    if (Ancienete > 5)
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif bleu");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
