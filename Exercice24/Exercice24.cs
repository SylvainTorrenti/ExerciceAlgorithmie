float Prix1 = 15.00f;
float Prix2 = 2.00f;
float Prix3 = 5.00f;
float Prix4 = 27.00f;
float Prix5 = 35.00f;
float Argent;
float Rendu; 

float Somme = Prix1 + Prix2 + Prix3 + Prix4 + Prix5;
Console.WriteLine("La somme est de " + Somme);

Console.WriteLine("Entrez l'argent donné");
Argent = float.Parse(Console.ReadLine());

if (Argent < Somme)
{
    Console.WriteLine("Vous n'avez pas donner assez d'argent");
    Console.WriteLine("Entrez l'argent donné");
    Argent = float.Parse(Console.ReadLine());
}
if (Argent > Somme)
{
    Rendu = Argent - Somme;
    do
    {
        if (Rendu >= 10)
        {
            Console.WriteLine("10 euros");
            Rendu = Rendu - 10;
        }
        else if (Rendu >= 5)
        {
            Console.WriteLine("5 euros");
            Rendu = Rendu - 5;
        }
        else if (Rendu >= 1)
        {
            Console.WriteLine("1 euros");
            Rendu = Rendu - 1;
        }
    } while (Rendu >0);
}

Console.ReadLine();