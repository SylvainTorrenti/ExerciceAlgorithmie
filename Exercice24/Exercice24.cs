float Prix1 = 15.00f;
float Prix2 = 2.00f;
float Prix3 = 5.00f;
float Prix4 = 27.00f;
float Prix5 = 35.00f;
float Argent;
float Rendu;

float Somme = Prix1 + Prix2 + Prix3 + Prix4 + Prix5;
Console.WriteLine("La somme est de " + Somme); // calcul la somme des prix

Console.WriteLine("Entrez l'argent donné");
Argent = float.Parse(Console.ReadLine()); // stock l'argent donné pour payé

while (Argent < Somme) // tant que l'argent donné est < à la somme
{
    Console.WriteLine("Vous n'avez pas donner assez d'argent");
    Console.WriteLine("Entrez l'argent donné");
    Argent = float.Parse(Console.ReadLine());
}
if (Argent > Somme) // si l'argent donné est > somme
{
    Rendu = Argent - Somme; // calcul du rendu
    do // fait
    {
        if (Rendu >= 10) // si le est >= 10
        {
            Console.WriteLine("10 euros");
            Rendu = Rendu - 10; // enleve 10 au rendu
        }
        else if (Rendu >= 5) // si le est >= 5
        {
            Console.WriteLine("5 euros");
            Rendu = Rendu - 5;// enleve 5 au rendu
        }
        else if (Rendu >= 1) // si le est >= 1
        {
            Console.WriteLine("1 euros");
            Rendu = Rendu - 1; // enleve 1 au rendu
        }
    } while (Rendu > 0); // tant que le rendu est > 0
}

Console.ReadLine();