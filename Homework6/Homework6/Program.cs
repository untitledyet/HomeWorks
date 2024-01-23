
class Program
{
    static void Main()
    {
        /*
        #region ArraySolution




        int[] arrayOdd = new int[] { };
        int[] arrayEven = new int[] { };

        Console.Write("Input Number : ");
        var inputNumberString = Console.ReadLine();

        if (int.TryParse(inputNumberString, out int inputNumberInt))
        {
            for (int i = 1; i <= inputNumberInt; i++)
            {
                if (i % 2 == 0)
                {
                    arrayEven = arrayEven.Concat(new[] { i }).ToArray();
                }
                else if (i % 2 == 1)
                {
                    arrayOdd = arrayOdd.Concat(new[] { i }).ToArray();
                }
                else
                {
                    Console.WriteLine("Something went Wrong");
                }
            }
        }
        else
        {
            Console.WriteLine("Please Enter a valid number");
        }

        Console.WriteLine("ODD Numbers");
        foreach (var i in arrayOdd)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("EVEN Numbers");
        foreach (var j in arrayEven)
        {
            Console.WriteLine(j);
        }

        #endregion */ //Solution With Array


        /*
        #region ListSolution

        List<int> numbersOdd = new List<int>();
        List<int> numbersEven = new List<int>();

        Console.Write("Input Number : ");
        var inputNumberString = Console.ReadLine();

        if (int.TryParse(inputNumberString, out int inputNumberInt))
        {
            for (int i = 1; i <= inputNumberInt; i++)
            {
                if (i%2 ==0 )
                {
                    numbersEven.Add(i);
                }
                else if (i%2 == 1)
                {
                    numbersOdd.Add(i);
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }

            Console.WriteLine("Odd Numbers");
            foreach (var i in numbersOdd)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("");
            Console.WriteLine("Even Numbers");
            foreach (var j in numbersEven)
            {
                Console.Write(j + ", ");
            }

        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }

        #endregion */ //Solution With List 


        /*
        #region Contacts

        var contacts = new Dictionary<string, int>()
        {
            { "კომბლე", 598874837 },
            { "წითელქუდა", 568726345 },
            { "ნაცარქექია", 555827384 },
            { "დევი", 514983745 }
        };

        foreach (var contactList in contacts)
        {
            Console.WriteLine(contactList);
        }

        Console.WriteLine();

        Console.WriteLine("ნომრის დამატება (1)");
        Console.WriteLine("ნომრის წაშლა (2)");
        Console.WriteLine("ნომრის განახლება (3)");
        Console.Write("აირჩიეთ მოქმედება : ");


        var selectedActionString = Console.ReadLine();

        if (int.TryParse(selectedActionString, out int selectedActionInt))
        {
            if (selectedActionInt == 1)
            {
                Console.WriteLine();
                Console.Write("სახელი : ");
                var inputName = Console.ReadLine();
                Console.Write("ნომერი : ");
                var inputNumberString = Console.ReadLine();

                if (int.TryParse(inputNumberString, out int inputNumberInt))
                {
                    if (contacts.ContainsKey(inputName))
                    {
                        Console.WriteLine("ასეთი კონტაქტი უკვე არსებობს");
                    }
                    else
                    {
                        contacts.Add(inputName, inputNumberInt);

                        foreach (var contactList in contacts)
                        {
                            Console.WriteLine(contactList);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ჩაწერე ნომერი სწორ ფორმატში");
                }
            }
            else if (selectedActionInt == 2)
            {
                Console.Write("ჩაწერე სახელი, რომელი კონტაქტის წაშლაც გინდა : ");

                var removeContact = Console.ReadLine();

                if (contacts.ContainsKey(removeContact))
                {
                    contacts.Remove(removeContact);

                    Console.WriteLine();
                    foreach (var contactList in contacts)
                    {
                        Console.WriteLine(contactList);
                    }
                }
                else
                {
                    Console.WriteLine("ასეთი კონტაქტი არ არსებობს ");
                }
            }
            else if (selectedActionInt == 3)
            {
                Console.Write("ჩაწერე სახელი ვისი ნომრის განახლებაც გინდა :  ");
                var updateNumber = Console.ReadLine();


                if (contacts.ContainsKey(updateNumber))
                {
                    Console.Write("შეიყვანე ნომერი : ");
                    var newNumber = Console.ReadLine();

                    if (int.TryParse(newNumber, out int newNumberInt))
                    {
                        contacts[updateNumber] = newNumberInt;
                        foreach (var contactList in contacts)
                        {
                            Console.WriteLine(contactList);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ნომრის ფორმატი არასწორია");
                    }
                }
                else
                {
                    Console.WriteLine("ასეთი კონტაქტი არ არსებობს");
                }
            }
            else
            {
                Console.WriteLine("You must enter number between 1-3");
            }
        }
        else
        {
            Console.WriteLine("Something went wrong");
        }

        #endregion  */ //Contact List


        #region counter

        List<int> arrayNumbers = new List<int>();

        Console.Write("შეიყვანეთ მასივის ზომა : ");
        var arraySize = Console.ReadLine();


        if (int.TryParse(arraySize, out int arraySizeInt))
        {
            for (int i = 0; i < arraySizeInt; i++)
            {
                Console.Write($"Number {i + 1} ----- ");
                var inputNumber = Console.ReadLine();

                if (int.TryParse(inputNumber, out int inputNumberInt))
                {
                    arrayNumbers.Add(inputNumberInt);
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }

            var result = arrayNumbers.GroupBy(x => x)
                .Select(group => new
                {
                    Number = group.Key,
                    Count = group.Count(),
                    Sum = group.Sum()
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} appears {item.Count} times sum {item.Sum}");
            }
        }
        else
        {
            Console.WriteLine("არასწორი ფორმატი");
        }
        
        

        #endregion
    }
}