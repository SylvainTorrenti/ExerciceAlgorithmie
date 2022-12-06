float Somme = 0f;
float Argent;
float Rendu;
float Prix;

do
{
    Console.WriteLine("Entrez le prix de l'article");
    Prix =float.Parse(Console.ReadLine());
    Somme = Somme + Prix;
    
} while ( Prix != 0);

Console.WriteLine("Vous devez " + Somme + " euros");
Console.WriteLine("Entrez combien d'argent vous voulez donner");
Argent = float.Parse(Console.ReadLine());

while (Argent < Somme)
{
    Console.WriteLine("Vous n'avez pas donné assez");
    Console.WriteLine("Il faut donné minimum " + Somme);
    Console.WriteLine("Entrez combien d'argent vous voulez donner");
    Argent = float.Parse(Console.ReadLine());
}

Rendu = Argent - Somme;

if (Rendu == 0)
{
    Console.WriteLine("Vous avez donnez le compte");
}else
{
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
    } while (Rendu > 0);
}


Console.ReadLine();

