/****************************************************************************
*                                 M A I N                                   *
****************************************************************************/
//använd metoder här
Console.Clear();

// int svar =Addera(6,9);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera(6,9));
// Console.WriteLine($"6+9={Addera(6,9)
// string text = "Benjamin";
// Console.WriteLine($"text omvänt är {Vändtext(text)}");

// Console.WriteLine(multiplicera(6,9));
// Console.WriteLine(dividerar(6,9));

Console.WriteLine($"Detta ord är långt {Längst("hej","hejdå")} ");

Console.WriteLine("ANge ett tal: ");
int nyttTal= LäsInHeltal();





/****************************************************************************
*                              M E T O D E R                                *
****************************************************************************/
//skapa metoder här

/// <summary>
/// summera 2 tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2)
{
    int summa = tal1+tal2;
    return summa;
}

//vänder på texten
static string Vändtext(string text)
{
    string omvändText = "";
    for (int i = text.Length-1; i >= 0;  i--)
    {
        omvändText += text[i];

    }
    return omvändText;
}


/// <summary>
/// multiplicera
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double multiplicera(double tal1,double tal2 )
{
double summa = tal1*tal2;
return summa;
}

/// <summary>
/// dividera
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>

static double dividerar(double tal1, double tal2)
{
    double summa = tal1/tal2;
return summa;
}

//
static string Längst(string text1, string text2)
{

if (text1.Length > text2.Length)
{
    return text1;
}else{
     return text2;
}

}
//läser in heltal
static int LäsInHeltal()
{
    int tal=0;
    while (true)
    {
        //kolla om texten är ett tall
    string textSomBlirTal = Console.ReadLine();
    bool lyckades = int.TryParse(textSomBlirTal, out tal);
        if (lyckades ==true)
        {
            break;
        }
        else
        {
           System.Console.WriteLine("det var felaktgi inmatning"); 
        }
    }

    return tal;
}