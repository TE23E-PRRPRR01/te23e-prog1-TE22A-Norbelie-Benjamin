
Console.Clear();
Console.WriteLine("Hej hur många år är du?: ");

string alderText = Console.ReadLine();
int alder = int.Parse(alderText);


if (alder <= 5 )
{
    Console.WriteLine("Du är ett litet barn");
}
if (alder >= 6)
{
    Console.WriteLine("har eller pluggar i grundskolan");
}
if (alder >= 15)
{
    Console.WriteLine("Du är byxmyndig");
}
if (alder >= 18)
{
    Console.WriteLine("Du är myndig och kan rösta");
}
 if ( alder >= 20 )
{
    Console.WriteLine("Du kan även handla på systemet");
}
 if (alder >= 24)
{
Console.WriteLine("Du kan ta körkort för tung mc");
}
if (alder >=67 )
{
    Console.WriteLine("Kan du också gå i passion");
}
if (alder <= 83)
{
    Console.WriteLine("Du lever längre än den normala svensken");
}