// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

//globala variabler
//en lista för heltal
List<int> listaSlumptal = [];

//be användaren ange antal slumpade tal
Console.WriteLine("ange antal slumpade tal");
int antal =int.Parse(Console.ReadLine());

//be användaren ange min och max
Console.WriteLine("ange maximum antal slumpade tal");
int max =int.Parse(Console.ReadLine());
Console.WriteLine("ange minimum antal slumpade tal");
int min =int.Parse(Console.ReadLine());

//loopa 5 gånger 
for (int i = 0; i < antal; i++)
{

    //slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max+1);

//lägg till slumptalet i listan
listaSlumptal.Add(slumptal);

    Console.WriteLine($"slumpat tal {1+i}: {slumptal}");
}