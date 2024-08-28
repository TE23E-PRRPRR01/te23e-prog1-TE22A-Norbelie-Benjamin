// roligt fråge porgram

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.Gray;
Console.Write("Pogram för att skapa en rolig mening. ");
Console.Write("Ange ett djur i plurar form: ");
string djur = Console.ReadLine();
Console.Write("ange en sport: ");
string sport = Console.ReadLine();
Console.WriteLine(" Visste du att " + djur + " äslkar " + sport);
string faktan = Console.ReadLine();
Console.Write("nu vet du någon ny rolig fakta. ");


