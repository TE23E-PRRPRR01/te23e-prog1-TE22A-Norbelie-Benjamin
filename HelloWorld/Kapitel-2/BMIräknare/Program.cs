// Program för att räkna ut ditt BMI värde


using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Program för att räkna ut ditt BMI värde");

//läser in din vikt och längd
Console.WriteLine("Ange din längd(m): ");
double Längd = double.Parse(Console.ReadLine());
Console.WriteLine("Ange din vikt(kg): ");
double Vikt = double.Parse(Console.ReadLine());

//konvertera vikt och längd till BMI
double BMI = Vikt / (Längd*Längd);
Console.WriteLine($"Ditt Bmi är {BMI}");

