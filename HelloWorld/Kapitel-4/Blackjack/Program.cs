// här är ett simpelt program av spelet Blackjack
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

Console.Clear();
Console.WriteLine("Här är ett simpelt program av spelet Blackjack");


//kortens värde är 
//2-10=2-10
//knekt,dam,kung=10
//ess=1 eller 11

//variabler

int summaSpelare = 0;
int summaDator = 0;
int kort = 0;
int RD = 0;

//Dela ut två kort till spelaren
kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
summaSpelare += kort;
//Dela ut två kort till datorn
kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
summaDator += kort;
RD = Random.Shared.Next(1, 3);


//flera gånge(loop)
while (true)
{

    //skriv ut summorna
    Console.WriteLine($"Du har {summaSpelare} poäng");
    Console.WriteLine($"Datorn har {summaDator} poäng");

    //stanna eller dra ett kort
    Console.Write("Vill du ha ett nytt kort? (j/n)");
    string svar = Console.ReadLine().ToLower();

    if (svar == "n")
    {

        while (summaDator < 17)
        {
            kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
            summaDator += kort;
            //skriv ut kortet
            Console.WriteLine($"Dator fick {kort}");

        }
        break;
    }

    //ta ett extra kort
    kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
    summaSpelare += kort;
    //skriv ut kortet
    Console.WriteLine("Du fick {kort}");
    //datorn får också ett extra kort
    kort = Random.Shared.Next(1, 11); //@todo knäkt,dam och kung?
    summaDator += kort;
    //skriv ut kortet
    Console.WriteLine("Dator fick {kort}");




    //vem har vunnit?(21)


    //vem har vunnit?




}
//den som har närmast 21 har vunnit
if (summaSpelare > summaDator && summaSpelare <= 21)
{
    Console.WriteLine("du har vunnit");
}
else if (summaDator >= summaSpelare && summaDator <= 21)
{
    Console.WriteLine("Datorn vann");
}