// Program som smapar lista med slumpade tal samt validerar användarens
// inmatning för att se till att allt är giltigt
/* ******************************************************************
**                               Main                              **
********************************************************************/

// Skapar en variabel för antalet slumptal för global användning
int antal;
int max;
int min;

Console.Clear();
Console.WriteLine("""
Välkommen till v2 av Slumpad Lista.

""");

// Deklarerar variabler
// Skapa en tom lista för att spara det slumpade talet
List<int> listaSlumptal = [];

// En loop som frågar användaren tills den matar in ett giltigt svar
while (true)
{

    // Fråga användaren om hur många slumptal som ska genereras
    Console.Write("Hur många tal vill du slumpa fram? ");

    bool lyckades = int.TryParse(Console.ReadLine(), out antal); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (lyckades == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
}

// Koden nedan är fortsättningen efter att användaren angett ett giltigt antal slumptal (efter att loopen "breakat")
Console.WriteLine($"Du vill ha {antal} slumptal!");

// While-loop för att definiera min-värde
while (true)
{

    // Fråga användaren om min-värde
    Console.Write("Ange minimumvärde: ");

    bool lyckades = int.TryParse(Console.ReadLine(), out min); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (lyckades == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
}

// While-loop för att definiera max-värde
while (true)
{

    // Fråga användaren om max-värde
    Console.Write("Ange maximumvärde: ");

    bool lyckades = int.TryParse(Console.ReadLine(), out max); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (lyckades == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
}

// Loopar {antal} gånger
for (var i = 0; i < antal; i++)
{
    // Slumpar ett mellan {min} och {max}
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    // Lägger in slumptalet i en lista
    listaSlumptal.Add(slumptal);

    // Skriver ut
    Console.WriteLine($"Slumpat tal nummer {i + 1} är: {slumptal}");
}

/* ******************************************************************
**                               Main                              **
********************************************************************/

static int LäsInHeltal()
{

}
