/**********************************************
*                   M A I N                   *
**********************************************/

// Ett program för kryptering med Ceasar-chiffer
Intro();
string val = Console.ReadLine();
    
if (val == "1")
{
    KrypterarMeddeland();
}
else if (val == "2")
{
    DekrypteraMeddelande();
}
else
{
    Console.WriteLine("Ogiltigt val. Avslutar programmet.");
}







/**********************************************
*               M E T H O D S                 *
**********************************************/

static void Intro()
{
    Console.Clear();
    Console.InputEncoding = System.Text.Encoding.Unicode;
    Console.OutputEncoding = System.Text.Encoding.Unicode;


    Console.WriteLine("Ceasar-krypto: Kryptera eller dekryptera ett meddelande.");
    Console.WriteLine("1. Kryptera meddelande");
    Console.WriteLine("2. Dekryptera meddelande");
    Console.Write("Ange ditt val: ");
}


static void KrypterarMeddeland()
{
    // Kryptera meddelande


    Console.WriteLine("Ett program för kryptering med Ceasar-chiffer");

    // alfabetet, lista av bokstäver att använda
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    // ange ett meddelande
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    // ange nyckel
    Console.WriteLine("Ange en nyckel till det krypterade meddelandet (mellan 1 till 9): ");
    int nyckel = int.Parse(Console.ReadLine());

    // krypterat meddelande som vi bygger upp
    string krypteratMeddelande = "";

    foreach (char bokstav in meddelande)
    {
        // hitta bokstavens position (index) i alfabetet
        int index = alfabetet.IndexOf(bokstav);

        // om bokstaven finns i alfabetet
        if (index != -1)
        {
            // Ceasar kryptering, addera nyckeln
            int nyIndex = (index + nyckel) % alfabetet.Length; // för att snurra runt alfabetet

            // plocka ut bokstaven för nya index
            char krypteradBokstav = alfabetet[nyIndex];
            krypteratMeddelande += krypteradBokstav;
        }
        else
        {
            // om bokstaven inte finns i alfabetet, lägg till den oförändrad
            krypteratMeddelande += bokstav;
        }
    }

    // skriv ut det krypterade meddelandet
    Console.WriteLine($"Krypterat meddelande: {krypteratMeddelande}");

}


static void DekrypteraMeddelande()
{
    // Dekryptera meddelande
    Console.WriteLine("Ett program för dekryptering med Ceasar-chiffer");

    // alfabetet, lista av bokstäver att använda
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    // ange ett krypterat meddelande
    Console.Write("Ange det krypterade meddelandet: ");
    string krypteratMeddelande = Console.ReadLine().ToUpper();

    // ange nyckel
    Console.WriteLine("Ange en nyckel för dekrypteringen (mellan 1 till 9): ");
    int nyckel = int.Parse(Console.ReadLine());

    // dekrypterat meddelande som vi bygger upp
    string dekrypteratMeddelande = "";

    foreach (char bokstav in krypteratMeddelande)
    {
        // hitta bokstavens position (index) i alfabetet
        int index = alfabetet.IndexOf(bokstav);

        // om bokstaven finns i alfabetet
        if (index != -1)
        {
            // Ceasar dekryptering, subtrahera nyckeln
            int nyIndex = (index - nyckel + alfabetet.Length) % alfabetet.Length; // för att snurra runt alfabetet

            // plocka ut bokstaven för nya index
            char dekrypteradBokstav = alfabetet[nyIndex];
            dekrypteratMeddelande += dekrypteradBokstav;
        }
        else
        {
            // om bokstaven inte finns i alfabetet, lägg till den oförändrad
            dekrypteratMeddelande += bokstav;
        }
    }

    // skriv ut det dekrypterade meddelandet
    Console.WriteLine($"Dekrypterat meddelande: {dekrypteratMeddelande}");
}


