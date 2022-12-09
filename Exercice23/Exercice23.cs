int Nombre;
int Proposition;
int Coup = 0;
Random objRandom = new Random();
Nombre = objRandom.Next(100);
do //fait
{
    Console.WriteLine("Entrez votre proposition");
    Proposition = int.Parse(Console.ReadLine());
    Coup = Coup + 1; // ajoute 1 au compte de coup
    if (Proposition > Nombre) // si la proposition est > au nombre à trouver
    {
        Console.WriteLine("Le nombre a deviner est plus petit");
    }
    else if (Proposition < Nombre) // si la proposition est < au nombre à trouver
    {
        Console.WriteLine("Le nombre a deviner est plus grand");
    }
    else // si les condition precedentes sont fausse
    {
        Console.WriteLine("Bravo vous avez trouvez en " + Coup + " coup");
    }
} while (Proposition != Nombre); // tant que le nombre n'est pas trouvé


Console.ReadLine();