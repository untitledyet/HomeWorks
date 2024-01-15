int myAge = 28;

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Daviti Meskhidze");
Console.Write("Guess My Age: ");
string probablyAge = Console.ReadLine();

if (int.Parse(probablyAge) == myAge)
{
    Console.WriteLine("You Are Right. I am " + probablyAge + " Years Old");
}
else
{
    Console.WriteLine("You Are Wrong. I am not " + probablyAge + " Years Old");
}