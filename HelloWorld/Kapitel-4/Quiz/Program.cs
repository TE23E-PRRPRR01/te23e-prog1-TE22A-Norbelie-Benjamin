// Quiz om Europa

using System.Formats.Asn1;

int poäng = 0;
Console.Clear();
Console.WriteLine("Quiz om Europa där du ska gissa städer");


while (true)
{


    Console.WriteLine("Lisabon finns i vilket land?: ");
    Console.WriteLine("a)Spanien");
    Console.WriteLine("b)Italien");
    Console.WriteLine("c)Portugal");
    string svar = Console.ReadLine();

    if (svar == "c")
    {
        poäng++;
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("Rätt!,nästa fråga"); 
        Thread.Sleep(3000);
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.White;
        break;

    }else{
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Du har fel");
        poäng--;
         Thread.Sleep(800);
        Console.ForegroundColor=ConsoleColor.White;
    }


}

while (true)
{


    Console.WriteLine("budapest finns i vilket land?: ");
    Console.WriteLine("a)Ungern");
    Console.WriteLine("b)Kroatsien");
    Console.WriteLine("c)Slovakien");
    string svar = Console.ReadLine();

    if (svar == "a")
    {
        poäng++;
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("Rätt!,nästa fråga"); 
        Thread.Sleep(3000);
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.White;
        break;

    }else{
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Du har fel");
         Thread.Sleep(800);
         poäng--;
        Console.ForegroundColor=ConsoleColor.White;
    }


}

while (true)
{


    Console.WriteLine("Tallin finns i vilket land?: ");
    Console.WriteLine("a)Estland");
    Console.WriteLine("b)Lettland");
    Console.WriteLine("c)Litauen");
    string svar = Console.ReadLine();

    if (svar == "a")
    {
        poäng++;
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("Rätt!,nästa fråga"); 
        Thread.Sleep(3000);
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.White;
        break;

    }else{
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Du har fel");
         Thread.Sleep(800);
         poäng--;
        Console.ForegroundColor=ConsoleColor.White;
    }


}

while (true)
{


    Console.WriteLine("Minsk finns i vilket land?: ");
    Console.WriteLine("a)Serbien");
    Console.WriteLine("b)Belarus");
    Console.WriteLine("c)Polen");
    string svar = Console.ReadLine();

    if (svar == "b")
    {
        poäng++;
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("Rätt!, du är nu klar"); 
        Thread.Sleep(3000);
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.White;
        break;

    }else{
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Du har Fel Idiot");
        Thread.Sleep(800);
        poäng--;
        Console.ForegroundColor=ConsoleColor.White;
    }


}
