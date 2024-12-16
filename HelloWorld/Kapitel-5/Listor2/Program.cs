Console.Clear();
Console.WriteLine("Allt om listor");

//skapa en lista
List<string> listaNamn = [];

//infoga i en lista
listaNamn.Add("Alexa"); //verb
listaNamn.Add("Alexandra");
Console.WriteLine(listaNamn.Count);

//skriv ut lista
foreach (var namn in listaNamn)
{
    System.Console.Write($"{namn}, ");
}

//skriv ut första elementet i listan (index=0)
Console.WriteLine($"Första elementet: {listaNamn[0]}");

for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"{i+1}- {listaNamn[i]}");
}

for (var i = 0; i < listaNamn.Count; i++)
{
    Console.WriteLine($"{i+1} - {listaNamn[i]}");
}