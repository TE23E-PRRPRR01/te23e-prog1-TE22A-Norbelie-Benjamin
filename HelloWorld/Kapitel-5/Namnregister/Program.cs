// Här har du ett namn register
//Skapa ett register
using System.Net.Http.Headers;
Console.Clear();
Console.WriteLine("Ett litet namnregister");
List<string> namnlista = [];

//Programloopen
while (true)
{


    //visa en meny
    Console.WriteLine("""

1. Registrera namn 
2. Skriva ut alla namn 
3. Avsluta
Ange ditt val: 
""");
    String val = Console.ReadLine();

    if (val == "3")
    {
        break;
    }
    else if (val == "2")
    {

        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet}, ");
        }

    }
    else if (val == "1")
    {
        Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);
        //skriv ut hela listan på en rad


    }


}