/**********************************************
*                   M A I N                   *
**********************************************/
Console.Clear();


while (true)
{
    Presentation();
    string val = Console.ReadLine();
    if (val == "1")
    {
        Addition();
    }else if (val == "2")
    {
        Subtraktion();
    }
    else if (val == "3")
    {
        Multiplikation();
    }
    else if (val == "4")
    {
        Division();
    }
    else if (val == "5")
    {
        break;
    }
}


/**********************************************
*               M E T H O D S                 *
**********************************************/
static void Presentation()
{
    System.Console.WriteLine("Välj ett av följande alternativ");
    System.Console.WriteLine("""
        1. Addition
        2. Subtraktion
        3. Multiplikation
        4. Division
        5. Avsluta programmet
   """);
   
}

static void Addition()
{
System.Console.WriteLine("Välj två tal som ska adderas");
System.Console.WriteLine("Tal1: ");
float Tal1 = Console.ReadLine();


System.Console.WriteLine("Tal1: ");

}
static void Subtraktion()
{

}
static void Multiplikation()
{

}
static void Division()
{

}
