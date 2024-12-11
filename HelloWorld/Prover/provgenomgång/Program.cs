Console.Clear();
Console.WriteLine("Filmregister");

//Lista för lagring
List<string> listaFilmer = [];

//fråga användaren
Console.WriteLine("Ange antal filmer per sida (3-5): ");
string antalText = Console.ReadLine();
int antal =0;
bool success = int.TryParse(antalText, out antal);

while (true)
{

    //visa en meny
    Console.WriteLine("""

1. Lägg till filmer
2. Lista alla filmer
3. sök en film
4. avsluta

""");
System.Console.WriteLine("\n");


    string val = Console.ReadLine();
    if (val == "1")
    {
        for (var i = 0; i < antal; i++)
        {
            Console.WriteLine("Ange namn på filmen: ");
            string namn = Console.ReadLine();
            listaFilmer.Add(namn);
        }
    }

    if (val == "2")
    {
        foreach (var filmnanmn in listaFilmer)
        {
            Console.Write($"- {filmnanmn}" );
        }
    }
    if (val == "3")
    {
        Console.WriteLine("Ange den första bokstaven i de namn du söker: ");
        string bokstav = Console.ReadLine();
        foreach (var filmnanmn in listaFilmer)
        {
            if (filmnanmn.StartsWith(bokstav))
            {
                System.Console.WriteLine(filmnanmn);
            }
        }

    }

    if (val == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("du har inte valt ett gilltigt svarsalternativ");
    }
}