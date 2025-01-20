/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 *********************************************** */

using System.Diagnostics;

visaIntro();

while (true)
{
    // Skriva ut menyn
    visaMeny();
    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = LäsInHeltal();

        // Skriv ut fyrkanten
        skapaFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = LäsInHeltal();

        // Skriv ut triangeln
            skapaTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}








/* **********************************************
 *  Metoder 
 ********************************************** */

/// <summary>
/// visara användaren introt
/// </summary>
static void visaIntro()
{
    Console.Clear();
    Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");
}

/// <summary>
/// visar användaren menyn
/// </summary>

static void visaMeny()
{
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// kollar så användaren har anget ett giltigt tal
/// </summary>
/// <returns></returns>
static int LäsInHeltal()
{

    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;

}

/// <summary>
/// skapapar användaren oen fyrkant
/// </summary>
/// <param name="tal"></param>
static void skapaFyrkant(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

}

/// <summary>
/// skapar användaren en triangel
/// </summary>
/// <param name="tal"></param>
static void skapaTriangel(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void avslut()
{
    
}