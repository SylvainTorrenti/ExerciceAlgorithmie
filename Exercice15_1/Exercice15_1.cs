int Point = 0;
Console.WriteLine("Entrez votre age");
int Age = int.Parse(Console.ReadLine()); // stock l'age de l'utilisateur
Console.WriteLine("Entrez vos années de permis");
int Permis = int.Parse(Console.ReadLine()); // stock les années de permis de l'utilisateur
Console.WriteLine("Combien d'accident avez vous eu?");
int Accident = int.Parse(Console.ReadLine()); // stock le nombre d'accident de l'utilisateur
Console.WriteLine("Depuis combien d'années êtes vous parmis nous?");
int Ancienete = int.Parse(Console.ReadLine()); // stock l'ancieneté de l'utilisateur

if (Age < 25)
{
    Point++;
}
if (Permis < 2)
{
    Point++;
}
while (Accident != 0)
{
    Point++;
    Accident--;
}
if (Ancienete > 5)
{
    Point--;
}
if (Point == -1)
{
    Console.WriteLine("Vous êtes au tarif bleu");
}
if (Point == 0)
{
    Console.WriteLine("Vous êtes au tarif vert");
}
if (Point == 1)
{
    Console.WriteLine("Vous êtes au tarif orange");
}
if (Point ==2 )
{
    Console.WriteLine("Vous êtes au tarif orange");
}
if (Point >= 3)
{
    Console.WriteLine("Vous êtes refusez");
}
