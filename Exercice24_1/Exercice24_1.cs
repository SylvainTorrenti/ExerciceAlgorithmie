float Somme = 0f;
float Argent;
float Rendu;
float Prix;

do //fait
{
    Console.WriteLine("Entrez le prix de l'article");
    Prix =float.Parse(Console.ReadLine());
    Somme = Somme + Prix; // ajoute l'entrée de l'utilisateur pour caclculer la somme
    
} while ( Prix != 0); // Tant que l'utilisateur ne rentre pas 0

Console.WriteLine("Vous devez " + Somme + " euros"); //affiche la somme dûe
Console.WriteLine("Entrez combien d'argent vous voulez donner");
Argent = float.Parse(Console.ReadLine()); // stock combien l'utilisateur donne

while (Argent < Somme) // tant que l'argent donné < somme
{
    Console.WriteLine("Vous n'avez pas donné assez");
    Console.WriteLine("Il faut donné minimum " + Somme);
    Console.WriteLine("Entrez combien d'argent vous voulez donner");
    Argent = float.Parse(Console.ReadLine());
}

Rendu = Argent - Somme; // calcul le rendu

if (Rendu == 0) // si le rendu = 0 
{
    Console.WriteLine("Vous avez donnez le compte");
}else // sinon 
{
    do //fait
    {
        if (Rendu >= 10) // si le rendu > 10
        {
            Console.WriteLine("10 euros");
            Rendu = Rendu - 10;// enlêve 10 au rendu
        }
        else if (Rendu >= 5)// si le rendu > 10
        {
            Console.WriteLine("5 euros");
            Rendu = Rendu - 5;// enlêve 5 au rendu
        }
        else if (Rendu >= 1)// si le rendu > 10
        {
            Console.WriteLine("1 euros");
            Rendu = Rendu - 1;// enlêve 1 au rendu
        }
    } while (Rendu > 0);//Tant que le rendu > 0
}


Console.ReadLine();

