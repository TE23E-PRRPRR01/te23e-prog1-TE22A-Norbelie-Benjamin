// 
Console.Clear();



//använd metoden
SKIT();

//namn metod
RegistreraNamn();

/// <summary>
/// metod som säger tjena
/// </summary>

static void BS()
{
    Console.WriteLine("Tjena");
}
static void SKIT()
{
    Console.WriteLine("""
    1- Lägg till uppgift
    2- ta bort uppgift
    3- skriv ut alla uppgift
    4-avslut
    """);
}
static void RegistreraNamn()
{
Console.WriteLine("Ange namn: ");
string namn =Console.ReadLine();
Console.WriteLine($"Tjena, {(namn)}");
}