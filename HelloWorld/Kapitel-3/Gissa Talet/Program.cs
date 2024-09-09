//Ett littet spel - gissa ett hemligt heltal
using System.Linq.Expressions;

Console.Clear();
Console.WriteLine("Ett littet spel - gissa ett hemligt heltal");

//slumpa ett tal
int slumptalet = Random.Shared.Next(1, 101);
Console.WriteLine($"Slumptalet är {slumptalet}");

Console.Write("Gissa ett tall 1-100: ");
// läs in texten, tex "100"
string gissningText = Console.ReadLine();
//konvertera texten till ett heltal, blir 100
int gissning = int.Parse(gissningText);


if (gissning == slumptalet)
{
    Console.WriteLine("bra du har gissat rätt!");
}
else if (gissning > slumptalet)
{
    Console.WriteLine("du har gissat för högt");
}
else
{
    Console.WriteLine("för lågt");
}


