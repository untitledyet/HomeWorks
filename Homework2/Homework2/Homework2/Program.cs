namespace Homework2
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Daviti Meskhidze");
            Console.Write("Guess My Age :");
            string probablyAge = Console.ReadLine();

            int realAge = 28;
            if (int.Parse(probablyAge) == realAge)
            {
                Console.WriteLine("You Are Right. I am " + realAge + " yesrs old");
            }
            else
            {
                Console.WriteLine("You Are Wrong. I am " + realAge + " yesrs old");
            }

            ;
        }
    }
}