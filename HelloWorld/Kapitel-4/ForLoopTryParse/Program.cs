
Console.Clear();
Console.WriteLine("For-Loop Example");

// Variabel för att lagra antalet repetitioner
int antalLoop;

// Läs in antal från användaren och validera inmatningen
while (true)
{
    Console.WriteLine("Ange antal loopar (1-10): ");
    bool Godkänd = int.TryParse(Console.ReadLine(), out antalLoop);

    // Kontrollera att inmatningen är ett tal mellan 1 och 10
    if (Godkänd && antalLoop >= 1 && antalLoop <= 10)
    {
        break;  // Bryt loopen om inmatningen är giltig
    }
    else
    {
        Console.WriteLine("Ogiltig inmatning. Var god ange ett tal mellan 1 och 10.");
    }
}

// Skriv ut namnet tillsammans med en nummer i loopen
string Namnet = "Alex B";
for (int i = 0; i < antalLoop; i++)
{
    Console.WriteLine($"{i+1} {Namnet}");  // Skriv ut numret följt av namnet
}
 // Be användaren mata in ett tal för beräkningar
        double användartal;
        while (true)
        {
            Console.WriteLine("Ange ett tal för beräkningar: ");
            bool RättNumer = double.TryParse(Console.ReadLine(), out användartal);

            if (RättNumer && användartal<= 10 && användartal>=1)
            {
                break;  // Bryt loopen om inmatningen är ett giltigt tal
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Var god ange ett giltigt tal.");
            }
        }

        // Utför och skriv ut beräkningarna
        double multiplicerat = användartal * 2;
        double dividerat = användartal / 2;
        double adderat = användartal + 2;
        double subtraherat = användartal - 2;

        Console.WriteLine($"Multiplicerat med 2: {multiplicerat}");
        Console.WriteLine($"Dividerat med 2: {dividerat}");
        Console.WriteLine($"Adderat med 2: {adderat}");
        Console.WriteLine($"Subtraherat med 2: {subtraherat}");
    



