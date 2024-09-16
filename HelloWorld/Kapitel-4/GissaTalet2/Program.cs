// Spelet- gissa ett slumptal 1-100
using System.Runtime.Intrinsics.Arm;
int gissningar = 0;

Console.Clear();
Console.WriteLine("Spelet- gissa ett slumptal där du vläjer min och max värde");
Console.WriteLine("välj ett minimum värde: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("välj ett maximum värde: ");
int max = int.Parse(Console.ReadLine());
//Slumpar ett tal mellan 1-100
int slumptal = Random.Shared.Next(min, max + 1);

//upprepning - loop
while (true)
{

    //ställer frågan till användaren
    Console.Write($"Gissa ett tal ({min}-{max}): ");
    int gissning = int.Parse(Console.ReadLine());
    gissningar++;


    //kontrollera om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat, på {gissningar}st gissningar");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt");
    }
    else
    {
        Console.WriteLine("För lågt");
    }

    //vill användaren gissa igen
    Console.Write("Vill du gissa en gång till? (j/n): ");
    string svar = Console.ReadLine();
    if (svar == "n")
    {
        break;
    }


}


// slut på spelet
Console.WriteLine("Slut, Tack för att du spleat mitt fina spel");
