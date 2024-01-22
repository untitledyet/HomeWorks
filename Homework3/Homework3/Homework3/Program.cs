using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Console.Write("Input Number : ");
        string inputNumber = Console.ReadLine();

        if (int.TryParse(inputNumber, out int intNumber))
        {
            if (intNumber % 5 == 0)
            {
                Console.WriteLine($"{inputNumber} is evenly divisible by 5");
            }
            else if (intNumber % 5 != 0)
            {
                Console.WriteLine($"{intNumber} is NOT evenly divisible by 5");
            }
        }

        else
        {
            Console.WriteLine($"{inputNumber} is not valid Number Format");
        }


        double number1 = 0;
        double number2 = 238;

        double sum = number1 + number2;
        double difference = (number1 > number2) ? number1 - number2 : number2 - number1;
        double multipled = number1 * number2;
        double division;

        Console.WriteLine($"Sum =  {sum}");
        Console.WriteLine($"Difference =  {difference}");
        Console.WriteLine($"Multipled =  {multipled}");

        if (number1 > number2 & number2 != 0)
        {
            division = number1 / number2;
            Console.WriteLine($"Division = : {division}");
        }
        else if (number2 > number1 & number1 != 0)
        {
            division = number2 / number1;
            Console.WriteLine($"Division = : {division}");
        }
        else
        {
            Console.WriteLine("Division : Not Allowed To Divide By Zero");
        }


        var x = 8;
        var y = 9;

        var z = 0;

        z = y;
        y = x;
        x = z;
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);


        Console.Write("Input Number : ");
        var numberForMultiple = Console.ReadLine();


        if (int.TryParse(numberForMultiple, out int intInputNumber))
        {
            for (int i = 0; i <= 9; i++)
            {
                int multiple = intInputNumber * i;
                Console.WriteLine($"{intInputNumber} * {i} = {multiple}");
            }
        }
        else
        {
            Console.WriteLine("Something Went Wrong");
        }


        Console.Write("Input Number : ");
        var n = Console.ReadLine();

        if (int.TryParse(n, out int intN))
        {
            for (int j = 1; j < intN; j++)
            {
                if (j % 2 == 0)
                {
                    int square = j * j;
                    Console.WriteLine($"{j} * {j} = {square}");
                }
            }
        }
        else
        {
            Console.WriteLine("Somethins Went Wrong");
        }

        
    }
}