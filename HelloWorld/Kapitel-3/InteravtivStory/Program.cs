// fråge formulär om välmående
using System.Buffers;
using System.Xml.Schema;
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hej hur mår du denna underbara dag?");


//Visa en smile
Console.WriteLine($"""
     ..::''''::..
   .;''        ``;.
  ::    ::  ::    ::
 ::     ::  ::     ::
 :: .:' ::  :: `:. ::
 ::  :          :  ::
  :: `:.      .:' ::
   `;..``::::''..;'
     ``::,,,,::''  
""");
Console.WriteLine("Mår du bra? (ja/nej)");
string answer = Console.ReadLine();

// kolla om svar e ja eller nej
if (answer == "ja")
{// y = yes
    Console.Write("Perfekt inget att lösa!");
    answer = Console.ReadLine();

}
else
{// n = no
    Console.Write("har du ont i huvudet? (ja/nej)");
    answer = Console.ReadLine();
    if (answer == "ja")
    {
        Console.WriteLine("Testa dricka vatten");
    }
    else
    {
        Console.WriteLine("har du ont i magen? (ja/nej)");
        if (answer == "ja")
        {
            Console.WriteLine("Testa gå på toaletten eller vila");
        }
        else
        {
            Console.WriteLine("mår du illa? (ja/nej)");
            if (answer == "ja")
            {
                Console.WriteLine("du bör vila och undvika skärmar ett tag");
            }
            else
            {
             Console.WriteLine("har du någon fysisk smärta? (ja/nej)");   
             if (answer == "ja")
             {
                Console.WriteLine("du bör söka hjälp av en läkare eller docktor");
             }
             else
             {
                Console.WriteLine("Mår du dåligt mentalt/psykiskt? (ja/nej)");
                if (answer == "ja")
                {
                    Console.WriteLine("sök hjälp av en psyolog");
                }
                else
                {
                   Console.WriteLine("jag har svårt att tro att du mår dåligt");
         
                }
             }
            }
        }
    }
}





Console.ReadKey();
