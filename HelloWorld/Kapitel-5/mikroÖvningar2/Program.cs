// 
Console.Clear();
Console.WriteLine("Hello, World!");
List<string> listaVänner = ["Cal", "Daria", "Deniss", "Malijos", "Dante"];
Console.WriteLine($"Mina vänner är {listaVänner}");
Console.WriteLine($"Mina kompisar är är: '{string.Join("','", listaVänner)}'");

List<string> listaStad = ["Stockholm", "Tallinn", "Moskva", "New Deli", "Los Angeles"];
Console.WriteLine($"Fem bra städer: '{string.Join("','", listaStad)}'");

List<string> listaÅr = ["2013", "1817", "1939", "1914", "2024"];
Console.WriteLine($"Fem viktiga årtal är: '{string.Join("','", listaÅr)}'");

Console.WriteLine($"Jag har en namnlista med {listaVänner.Count}");
Console.WriteLine("Första Namnet: " + listaVänner.First());
Console.WriteLine("Sista Namnet: " + listaVänner.Last());

List<string> listadryck = ["absoult", "cola", "redbull", "fanta", "brunnsvatten"];

