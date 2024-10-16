// En liten Morsekod app
using System.Linq.Expressions;

Console.Clear();
Console.WriteLine("En liten Morsekod app");

// två listor
List<string> alfabetet = ["A","B","C","D","E","F","G","H","I",
                        "J","K","L","M","N","O","P","Q","R",
                        "S","T","U","V","W","X","Y","Z","Å","Ä","Ö"," ","1","3","4","5","6","7","8","9","0"];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/",".----","..---","...--","....-",".....","-....","--...","---..","----.","-----" ];

Console.Write("Ange ett medelande att översätta: ");
string medelande = Console.ReadLine().ToUpper();


//gå igenom meddelandet
foreach (char bokstav in medelande)
{



    //hitta bokstaven i alfabetet
    int index = alfabetet.IndexOf(bokstav.ToString());

    if (index >= 0)
    {

        //hitta morsekoden
        string kod = morsekod[index];

        // Skriv ut morsekoden
        Console.Write($"{kod}");

        //spela ljudet
        //dvs loopa igenom kod
        foreach (char signal in kod)
        {
            if (signal == '.')
            {
                Console.Beep(1000, 100);
                Thread.Sleep(100);
            }
            else if (signal == '-')
            {

                Console.Beep(1000, 300);
                Thread.Sleep(100);
            }
            else if (signal == '/')
            {
                Console.Beep(1000, 0);
                Thread.Sleep(100);
            }


        }
        //pause
        Thread.Sleep(100);
    }
    else
    {
        Console.WriteLine("?");
    }
}


