// Program för att konvertera från Farenheit till Celsius
Console.Clear();
Console.WriteLine("Program för att konvertera från Farenheit till Celsius");

//Läser in temperaturen i Farenheit
Console.WriteLine("Ange temperaturen i Farenheit: ");
double tempFarenheit = double.Parse(Console.ReadLine());


//Konvertera Farenheit till Celsius
double tempCelsius = (tempFarenheit -32 ) * 5 / 9;

//skriva ut resultatet med decimaler
Console.WriteLine($"{tempFarenheit} F blir {tempCelsius} Celsius");