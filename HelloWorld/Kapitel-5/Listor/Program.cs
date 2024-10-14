// Använda listor för att hantera samlingar
Console.Clear();
//lista på trvliga frukter, tex "äpple","appeksin", "annanas"
List<string> frukter = ["äpple", "appeksin", "annanas"];
Console.WriteLine($"Min fruktlista: {frukter[0]}{frukter[1]}{frukter[2]}");

//Ändra i listan

frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}{frukter[1]}{frukter[2]}");


// gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine("Frukt");
}


//skriv ut varje sak på samma rad
//skapa en lista på valfri ska (4st)
//gav upp





//Skapa ett register
Console.Clear();
//en tom lista
List<string> namnlista = [];

//while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);
    //skriv ut hela listan på en rad

    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }



}