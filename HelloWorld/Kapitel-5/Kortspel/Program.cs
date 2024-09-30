// Hur man skapar listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;


Console.WriteLine("Slumpa kort ur en kortlek");

//skapa en lista kort
//List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];
//skapa en lista kort
List<string> kortlek = ["🂡👌", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];

//ett annat exemepl. lista på 3 årtal
//List<int> årtal =[1957,1969,1989];
int antal = 5;
while (antal > 0)
{

    //slumpa index
    int index = Random.Shared.Next(0, kortlek.Count);
    // Console.WriteLine($"Det slumpade index = {index}");

    //plocka ut det sjunde kortet
    string kort = kortlek[index];
    kortlek.RemoveAt(index);

    //skriv ut 7de kortet
    Console.WriteLine($"det slumpade kortet är {kort}");

    
    antal--;
    
}
        if (antal > 0)
        {
            Console.WriteLine("Inga fler kort att dra!");
        }