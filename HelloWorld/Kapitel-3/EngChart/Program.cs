// program som simulerar kända Engineering FlowChart
using System.Buffers;
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("välkommen till ingenjören flödesssgcema");

//Visa en ASCii art
Console.WriteLine($"""

                               _
                             _| |_
                           /~     ~\           
                         /'         `\      
                        (             )    
                        |             |    
                        |             |  
                        |             |
                        |             |
                        |             |
                        |             |
                        |             |
                        |             |
                        |             |
                        |             |
                        |             |
                      (~\_           _/~)
                      `\_ ~~-------~~ _/'
                         ~~---------~~
  
""");
Console.WriteLine("Does it move? (y/n)");
string answer = Console.ReadLine();

// kolla om svar e ja eller nej
if (answer == "y")
{// y = yes
    Console.Write("should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem");
    }
    else
    {
        Console.WriteLine(" Please use Duck Tape!");
    }
}
else
{// n = no
    Console.Write("should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Please use WD-40!");
    }
    else
    {
        Console.WriteLine("No Problem!");
    }
}





Console.ReadKey();
