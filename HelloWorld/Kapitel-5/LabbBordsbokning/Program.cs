// Detta är Centralrestaurangens bordshanterare
//Fil med bordsinformation hittades ej, ny information skapades.
Console.Clear();

//variabler/list
// Skapa en tom array för borden
List<string> bordsInformation = [];



// Format på tomt bord
string tomtBordBeskrivning = "0,Inga gäster";

// Antal bord
int antalbord = 4;

for (var i = 0; i < antalbord; i++)
{
    bordsInformation.Add(tomtBordBeskrivning);
}
//boka ett bord
Console.WriteLine("ange bords nr 1-4");
int bordsnummer = int.Parse(Console.ReadLine());
Console.WriteLine("ange bokningsnamn");
string namn = Console.ReadLine();
Console.WriteLine("antal gäster (1-4): ");
int antalGäster = int.Parse(Console.ReadLine());
bordsInformation[bordsnummer - 1] = $"{antalGäster},{namn}";



/*
Console.WriteLine("""
Detta är Centralrestaurangens bordshanterare 
Fil med bordsinformation hittades ej, ny information skapades.
""");


while (true)
{
    Console.WriteLine(""" 
1. Visa alla bord
2. Ändra bordsinformation
3. Markera att ett bord är ledigt
4. Avsluta programmet
Välj ett alternativ: 
""");
    string alternativText = Console.ReadLine();
    if (int.TryParse(alternativText, out int alternativInt))
    {
        if (alternativInt == 1)
        {
            Alternativ1();
        }
        else if (alternativInt == 2)
        {
            Alternativ2();
        }
        else if (alternativInt == 3)
        {
            Alternativ3();
        }
        else if (alternativInt == 4)
        {
            Alternativ4();
        }



    }
    else
    {
        Console.WriteLine($"Du savarde med ett ogiltigt alternativ");
    }

}

//functions

static void Alternativ1()
{
    Console.WriteLine("Du har valt att visa alla bord");
}
static void Alternativ2()
{
    Console.WriteLine("Vad är det för bords information du vill ändra");
    Console.WriteLine("Vilket bordsnummer vill du ändra informationen för?");
}
static void Alternativ3()
{

    Console.WriteLine("Du har valt att markera att ett bord tomt");
}
static void Alternativ4()
{
    Console.WriteLine("Du har valt att avsluta programet");
}


*/