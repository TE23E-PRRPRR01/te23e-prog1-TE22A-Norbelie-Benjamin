/****************************************************************************
*                                 M A I N                                   *
****************************************************************************/
Console.Clear();

//Skriva ut et medalend vertikalt
string meddelande1 = "TMåndag är skit";
// JA(meddelande1);
//Skriva ut et medalend vertikalt nr2
string meddalande2 = "Måndag Är Skit";
// JA(meddalande2);

// rita fyrkant med sid längd
// JAS (3);

//skriv text flera gånger
// UpprepaText("Lorem Ipsum" ,3);

//celsius till farenhiet
// CTillF(-40);

//kasta tärning flera antal gånger 
kastaT(6, 5);


/****************************************************************************
*                              M E T O D E R                                *
****************************************************************************/

/// <summary>
/// skriv meddelandet vertikalt
/// </summary>
/// <param name="meddelande"></param>

static void JA (string meddelande)
{


//Skriva ut et medalend vertikalt
for (var i = 0; i < meddelande.Length; i++)
{
    Console.WriteLine(meddelande[i]);
}
}


static void JAS(int sidlängd)
{
    
for (var i = 0; i < sidlängd; i++)
{
    for (var j = 0; j < sidlängd; j++)
    {
        Console.Write("🟥");
    }
    Console.WriteLine();
}
}

static void UpprepaText(string text, int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

static void CTillF (int konvertera)
{
    Console.WriteLine(konvertera *9/5 +32);
}

static void kastaT(int tärning, int många)
{
    for (var i = 0; i < många; i++)
    {
        
int f = Random.Shared.Next(tärning);
Console.WriteLine(f);
    }
}