// Program för att räkna ut kostnaden på biluthyrning
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Program för att räkna ut kostnaden på biluthyrning");

// räknar antal mil och längd på dagar
Console.WriteLine("Hur långt du ska kör den: ");
double Mil = double.Parse(Console.ReadLine());
Console.WriteLine("Hur länge ska du ha bilen: ");
double Dagar = double.Parse(Console.ReadLine());

//räkna totall kostnad
double kost = (Mil*5) + (Dagar*100) + 500;

// toltal kostnad
Console.WriteLine($"Din kostnad är {kost}kr");