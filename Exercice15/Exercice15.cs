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
            int Age = int.Parse(Console.ReadLine()); // stock l'age de l'utilisateur
            Console.WriteLine("Entrez vos années de permis");
            int Permis = int.Parse(Console.ReadLine()); // stock les années de permis de l'utilisateur
            Console.WriteLine("Combien d'accident avez vous eu?");
            int Accident = int.Parse(Console.ReadLine()); // stock le nombre d'accident de l'utilisateur
            Console.WriteLine("Depuis combien d'années êtes vous parmis nous?");
            int Ancienete = int.Parse(Console.ReadLine()); // stock l'ancieneté de l'utilisateur

            if (Age < 25) // verfie si l'utilisateur à - de 25 ans
            {
                if (Permis < 2) // verfie si l'utilisateur à - de 2 ans de permis
                {
                    if (Accident > 0) // verfie si l'utilisateur à eu un accident
                    {
                        Console.WriteLine("Nous ne pouvons vous assurer");
                    }
                    else // verfie si l'utilisateur n'à pas eu d'accident
                        Console.WriteLine("Vous êtes au tarif rouge");
                    if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                    }
                }
                else // si l'utilisateur à plus de 2 ans de permis
                {
                    if (Accident > 0) // verfie si l'utilisateur à eu un accident
                    {
                        Console.WriteLine("Vous êtes au tarif rouge");
                        if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                        }
                    }
                    else // verfie si l'utilisateur n'à pas eu d'accident
                        Console.WriteLine("Vous êtes au tarif Orange");
                    if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Vert");
                    }
                }
            }
            else // si l'utilisateur a plus de 25 ans
            {
                if (Permis < 2) // verfie si l'utilisateur à - de 2 ans de permis
                {
                    if (Accident > 0) // verfie si l'utilisateur à eu un accident
                    {
                        Console.WriteLine("Vous êtes au tarif rouge");
                        if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                        }
                    }
                    else // verfie si l'utilisateur n'à pas eu d'accident
                        Console.WriteLine("Vous êtes au tarif Orange");
                    if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif vert");
                    }
                }
                else // si l'utilisateur a + de 2ans de permis
                {
                    if (Accident > 2) // si l'utilisateur a eu + de 2 accidents
                    {
                        Console.WriteLine("Nous ne pouvons vous assurer");
                    }
                    else if ((Accident > 1) && (Accident <= 2)) // si l'utilisateur à eu 2 accidents
                    {
                        Console.WriteLine("Vous êtes au tarif rouge");
                        if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Orange");
                        }
                    }
                    else if ((Accident > 0) && (Accident <= 1)) // si l'utilisateur à eu 1 accident
                    {
                        Console.WriteLine("Vous êtes au tarif Orange");
                        if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                        {
                            Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif Vert");
                        }
                    }
                    else // verifie si l'utilisateur n'a pas eu d'accident
                        Console.WriteLine("Vous êtes au tarif Vert");
                    if (Ancienete > 5) // verfie si l'ancieneté de l'utilisateur est > 5 ans
                    {
                        Console.WriteLine("Vous bénéficié de l'avantage fidelité vous êtes au tarif bleu");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
