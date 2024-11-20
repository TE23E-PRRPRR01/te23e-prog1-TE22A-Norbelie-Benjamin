// For loop bonanza
Console.Clear();
int min=0;
while (true)
{
    
Console.WriteLine("Ange startvärde: ");
string minText = Console.ReadLine();

bool success = int.TryParse(minText, out min);

if(success==true){
    break;
}else{
    Console.WriteLine("Nu gick det fel");
}
}
int max=0;
while(true){

Console.WriteLine("Ange slutvärde: ");
string maxText = Console.ReadLine();

bool success = int.TryParse(maxText, out max);

if(success==true){
    break;
}else{
    Console.WriteLine("Nu gick det fel");
}
}
int summa=0;

Console.Write("Jämna tal: ");
for (int i = min; i < max+1; i++)
{
    summa+=i+1;
    if(i % 2 ==0){
Console.Write($"{i}, ");
    }

}

Console.Write("\nUdda tal: ");
for (int i = min; i < max+1; i++)
{
    summa+=i+1;
    if(i % 2 !=0){
Console.Write($"{i}, ");
    }

}

Console.WriteLine($"summan är {summa}");