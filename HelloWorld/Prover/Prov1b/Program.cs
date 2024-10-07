//Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
//Marginalskatten räknas ut baserat på din bruttolön.
//Med bruttolön avses din årslön före skatt.

using System.Globalization;

Console.WriteLine("""Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten. Marginalskatten räknas ut baserat på din bruttolön. Med bruttolön avses din årslön före skatt.  """);

Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

while (true)
{


    Console.WriteLine("Ange din bruttolön i kronor: ");
    int blön = int.Parse(Console.ReadLine());

    if (blön < 1000000 && blön > 10000)
    {

        Console.WriteLine("Vill du göra en ny beräkning? (j/n)");

        if (10000 <= blön && blön < 145000)
        {
            int netto = blön * (100 - 22) / 100;
            Console.WriteLine($"ditt netto är: {netto}");
        }
        else if (145000 <= blön && blön < 515000)
        {
            int netto = blön * (100 - 33) / 100;
            Console.WriteLine($"ditt netto är: {netto}");

        }
        else if (515000<=blön)
        {
            int netto = blön * (100 - 53) / 100;
            Console.WriteLine($"ditt netto är: {netto}");
        }
string loopa=Console.ReadLine().ToLower();

Console.WriteLine("Vill du göra en ny uträkning");
if(loopa!="J"){
break;
}

    }
    else
    {
        Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");
    }












}