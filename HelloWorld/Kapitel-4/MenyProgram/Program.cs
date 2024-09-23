// Litet meny program
Console.Clear();
Console.WriteLine("Litet meny program");
Console.InputEncoding=System.Text.Encoding.Unicode;
Console.OutputEncoding=System.Text.Encoding.Unicode;

//variabel för valet
string val="";

//programloop som snurrar tills användaren säger avsluta
while(true)
{
    //visar en meny och läser användarens val
    Console.WriteLine("""
    1.omvandla en text till versaler
    2.omvandla en text till gemener
    3.avsluta
    Välj ett av alternativen ovan:
    """);
    val =Console.ReadLine();
    
    //hantera användarens val
    if (val=="1")
    {
        Console.Write("Skriv in en text: ");
        string texten=Console.ReadLine().ToUpper();
        Console.WriteLine($"texten i versaler blir: {texten}");
        
    }
    else if(val=="2")
    {
        Console.Write("Skriv in en text: ");
        string texten=Console.ReadLine().ToLower();
        Console.WriteLine($"texten i versaler blir: {texten}");
        
    }
    else if(val=="3")
    {
        Console.WriteLine("Avslutar programet...");
        break;
    }
    else{
        Console.WriteLine("Ogiltigt svars alternativ");
    }


}