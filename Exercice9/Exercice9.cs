using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice9
{
    internal class Exercice9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre note entre 0 et 20");
            string Note = Console.ReadLine(); // Stock la note entrée
            int NoteConvertit = int.Parse(Note); // Convertit la note en Int
            if (NoteConvertit >= 10) //  si la note est supérieure ou égale à 10
            {
                Console.WriteLine("Admis");
            }
            if (NoteConvertit >= 8) // si la note est supérieure à 8 et inférieur à 10
            {
                Console.WriteLine("Rattrapage");
            }
            if (NoteConvertit < 8)
            {
                Console.WriteLine("Echec"); //  si la note est inférieure à 8
            }

            Console.ReadLine();
        }
    }
}
