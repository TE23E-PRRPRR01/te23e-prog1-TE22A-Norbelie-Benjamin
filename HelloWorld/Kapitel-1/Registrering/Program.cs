﻿// pogram för att registrerar för och efternamn...
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Write("Program för att registrera förnamn och efternamn...");
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);
Console.WriteLine($"Hej {förnamn} {efternamn}");

// är det Benjamin loggar in
if (förnamn == "Benjamin")
{
Console.WriteLine("Vad trevligt att du är tillbacka!");    
}
if (efternamn == "Norbelie")
{Console.WriteLine("fint namn");
    
}