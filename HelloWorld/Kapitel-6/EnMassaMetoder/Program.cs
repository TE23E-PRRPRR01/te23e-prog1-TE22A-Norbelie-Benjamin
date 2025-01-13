using System.Globalization;

Console.Clear();

Säghejnamn("Benji");

talIKvadrat(4);
/****************************************************************************
*                              M E T O D E R                                *
****************************************************************************/


static void Säghejnamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}
static void talIKvadrat(int nummer)
{
Console.WriteLine($"{nummer} är {nummer*nummer} i kvadrat");
}