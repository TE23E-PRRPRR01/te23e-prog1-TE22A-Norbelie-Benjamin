//Program för att konvertera tempraturen i celsius till farenehiet
Console.Clear();
Console.WriteLine("Program för att konvertera tempraturen i celsius till farenheit");

//läser in temp i Celsius
Console.Write("Ange tempratur i Celsius: ");
int tempCelsius = int.Parse(Console.ReadLine());

//konvertera till Farenheit
int tempFahrenheit = tempCelsius * 9 /5 +32;

//skriver ut resultatet
Console.WriteLine($" {tempCelsius} Celsius är {tempFahrenheit} Farenheit");