// 
Console.Clear();


List<string> ListaNamn = ["Anna", "Björn", "Cecilia"];

Console.Write("Nuvardnade lista: ");

Console.WriteLine(string.Join(",", ListaNamn));

Console.WriteLine("Ange ett namn att lägga till:");
string namn = Console.ReadLine();

// Lägg till ett element i listan
ListaNamn.Add($"{namn}");

Console.WriteLine("Listan efter tillägg:");

Console.WriteLine(string.Join(",", ListaNamn));

Console.WriteLine("Ange ett namn att ta bort:");
string namnAttTaBort = Console.ReadLine();

if (ListaNamn.Contains(namnAttTaBort))
{

    // Ta bort ett element från listan
    ListaNamn.Remove($"{namnAttTaBort}");
    Console.WriteLine(string.Join(",", ListaNamn));
}
else
{
    Console.WriteLine("Du har inte valt ett giltigt namn");
}
Console.WriteLine("Ange ett namn att söka efter:");
string hitta = Console.ReadLine();
if (ListaNamn.Contains($"{hitta}"))
{
    Console.WriteLine($"{hitta} finns i listan.");
    Console.WriteLine(string.Join(",", ListaNamn));
}
else
{
    Console.WriteLine($"{hitta} finns inte i listan.");

}

