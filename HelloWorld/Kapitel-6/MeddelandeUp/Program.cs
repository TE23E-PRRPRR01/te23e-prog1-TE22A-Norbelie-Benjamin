/****************************************************************************
*                                 M A I N                                   *
****************************************************************************/
Console.Clear();
string filnamn = "meddelande.txt";
VisaPresentation();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    if (val == "1")
    {
        Sparameddelande(filnamn);
    }
    else if (val == "2")
    {

        LäsMeddelande(filnamn);

    }
    else if (val == "3")
    {
File.Delete("meddelande.txt");

    }
    else if (val == "4")
    {

Console.WriteLine("Inget mer tack!");
Thread.Sleep(3000);
break;

    }
    else{
        Console.WriteLine("Oops, fel!");
    }

}




/**********************************************
*               M E T H O D S                 *
**********************************************/


/// <summary>
/// Presentation av programmet
/// </summary>
static void VisaPresentation()
{
System.Console.WriteLine("""
Program för att spara meddelande
""");
}
/// <summary>
/// Visar programets meny alla funktioner
/// </summary>
static void VisaMeny()
{
Console.WriteLine("""
1. spara meddelande
2. läs meddelande
3. ta bort meddelande
4. avsluta program
""");
}

/// <summary>
/// sparar användarens meddelande
/// </summary>
static void Sparameddelande(String filen)
{
System.Console.WriteLine("Ange ett meddelande: ");
string meddelande =Console.ReadLine();
File.WriteAllText("filen", meddelande);
System.Console.WriteLine("Meddelande sparat");
}

/// <summary>
/// läser ut använderns meddelande
/// </summary>
static void LäsMeddelande(string filen)
{
string meddelande = File.ReadAllText("filen");
Console.WriteLine("Ditt senaste meddelande: ");
System.Console.WriteLine(meddelande);
System.Console.WriteLine("---------------");
}