// Här är ett Text editor program
Console.Clear();
Console.WriteLine("Här är ett Text editor program");
string val = "";
string text = "";
while (true)
{

    Console.WriteLine("""

    Välj ett av följande alternativ:
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta programmet
    
    """);

    Console.Write("Dit val: ");
    text = Console.ReadLine();

    if (text == "1")
    {
        Console.WriteLine("Skriv in en text:");
        // Skriv text i filen
        val = Console.ReadLine();
        File.WriteAllText("filnamn.txt", val);
    }
    else if (text == "2")
    {
        Console.WriteLine("Text:");
        // Läs in text från filen
        val = File.ReadAllText("filnamn.txt");
        Console.WriteLine(val);

    }
    else if (text == "3")
    {
        Console.WriteLine("Tack för idag.");
        break;
    }
    else
    {
        Console.WriteLine("Du valde inte ett giltigt alternativ.");
    }
}

