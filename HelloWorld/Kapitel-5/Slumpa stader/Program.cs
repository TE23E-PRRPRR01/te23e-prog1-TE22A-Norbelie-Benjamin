// Hur man skapar listor
Console.Clear();


Console.WriteLine("Slumpa städer");

//skapa en lista kort
List<string> stader = new List<string> {
    "Stockholm", "Solna", "Nyköping", "Linköping", "Köping", "Norrköping", "Uppsala", "Kiruna", "Göteborg", "Umeå"
};


//ett annat exemepl. lista på 3 årtal
//List<int> årtal =[1957,1969,1989];
int antal = 1;
while (antal > 0)
{

    //slumpa index
    int index = Random.Shared.Next(0, stader.Count);

    // Console.WriteLine($"Det slumpade index = {index}");

    //plocka ut det sjunde kortet
    string stad = stader[index];

    //ta bort staden ur städerna
    stader.RemoveAt(index);

    //skriv ut 7de kortet
    Console.WriteLine($"det slumpade staden {stad}");

    
    antal--;
    
}
