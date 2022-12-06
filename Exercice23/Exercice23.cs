int Nombre;
int Proposition;
int Coup = 0;
Random objRandom = new Random();
Nombre = objRandom.Next(100);
do
{
    Console.WriteLine("Entrez votre proposition");
    Proposition = int.Parse(Console.ReadLine());
    Coup = Coup + 1;
    if (Proposition > Nombre)
    {
        Console.WriteLine("Le nombre a deviner est plus petit");
    }
    else if (Proposition < Nombre)
    {
        Console.WriteLine("Le nombre a deviner est plus grand");
    }
    else
    {
        Console.WriteLine("Bravo vous avez trouvez en " + Coup + " coup");
    }
} while (Proposition != Nombre);


Console.ReadLine();