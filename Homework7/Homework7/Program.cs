/*
#region  firstSolution

double smallSquareArea = 0;
double bigSqueareArea = 0;

Console.Write("შემოიტანეთ წრეწირის რადიუსი : ");
var radiusString = Console.ReadLine();

if (double.TryParse(radiusString, out double radiusInt))
{
    smallSquareArea = (radiusInt * radiusInt) * 2;
    bigSqueareArea  = Math.Pow(radiusInt * 2, 2);

    Console.WriteLine($"პატარა კვადრატის ფართობი = {smallSquareArea}");
    Console.WriteLine($"დიდი კვადრატის ფართობი = {bigSqueareArea}");
    Console.WriteLine($"სხვაობა დიდ და პატარა კვადრატების ფართობებს შორის = {bigSqueareArea - smallSquareArea}");


}
else
{
    Console.WriteLine("არასწორი რიცხვის ფორმატი");
}

#endregion */ //first Solution (Squares)

/*
#region Slot

Console.WriteLine("დაიწყე თამაში ");
var symbols = new List<int>();
Random random = new Random();

while (true)
{
    symbols.Clear();
    Console.Read();
    for (int i = 0; i < 3; i++)
    {
        int randomNumber = random.Next(1, 4);
        symbols.Add(randomNumber);
    }

    foreach (var item in symbols)
    {
        Console.Write(item + ", ");
    }

    bool jpWon = false;

    bool allElementsAreSame = symbols.All(x => x == symbols.First());

    if (allElementsAreSame)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("🎉 You Won Jackpot 🎉");
        break;
    }
    else
    {
        Console.WriteLine("No Jackpot");
    }
}

#endregion */ //Second Solution (Slot)

/*
#region Points


var results = new Dictionary<string, int>()
{
    {"win", 0},
    {"lose", 0},
    {"draw", 0}
};


Console.Write("win : ");
results["win"] = Convert.ToInt32(Console.ReadLine());
Console.Write("lose : ");
results["lose"] = Convert.ToInt32(Console.ReadLine());
Console.Write("draw : ");
results["draw"] = Convert.ToInt32(Console.ReadLine());

foreach (var item in results)
{
    Console.Write($"{item.Key} - {item.Value}  / ");
}

Console.WriteLine();
Console.WriteLine($"ჯამური ქულა = {(results["win"] * 3) + results["draw"]}");

#endregion */ //Solution Points

/*
#region WorkingHours


var workingHours = new List<int>();
string inputHours = "";
Console.Write("შემოიტანე ნამუშევარი საათების რაოდენობა კვირის დღეების მიხედვით და გამოყავი მძიმეებით : ");
inputHours = Console.ReadLine();

foreach (var item in inputHours.Split(','))
{
    if ( int.TryParse(item, out int intNumber))
    {
        workingHours.Add(intNumber);
    }
    else
    {
        continue;
    }

}

var result = 0;


for (int i = 0; i < workingHours.Count; i++)
{
    if (i<5)
    {
        if (workingHours[i] <=8 )
        {
            result += workingHours[i] * 10;
        }
        else
        {
            result += (8 * 10) + (workingHours[i] - 8) * 15;
        }
    }
    else
    {
        result += workingHours[i] * 20;
    }
}


foreach (var i in workingHours)
{
    Console.Write(i+" ");

}

Console.WriteLine();
Console.WriteLine(result);


#endregion */ //Working Hours

/*
#region Results

var myList = new List<int>();
var inputString = "";
Console.Write("შემოიტანე მიღწევები და გამოყავი მძიმეებით : ");
inputString = Console.ReadLine();

foreach (var item in inputString.Split(','))
{
    if ( int.TryParse(item, out int intNumber))
    {
        myList.Add(intNumber);
    }
    else
    {
        continue;
    }

}

var result = 0;
for (int i = 1; i < myList.Count; i++)
{
    if (myList[i] > myList[i-1])
    {
        result += 1;
    }
}

Console.WriteLine(result);

#endregion */ //Progress

/*
#region MyRegion


var myList = new List<string> { "Tinkivinki", "Dipsi", "Lala", "Po", "Nifnifni", "Nafnafi", "Nufnufi" };

Console.Write("Input Number : ");
var lenString = Console.ReadLine();

if (int.TryParse(lenString, out int lenInt))
{
    var filteredList = myList.Where(s => s.Length == lenInt).ToList();

    if (filteredList.Count != 0)
    {
        Console.Write("ასეთი სიგრძის ელემენტები : ");
        foreach (var item in filteredList)
        {
            
            Console.Write(item+", ");
            
        }
    }
    else
    {
        Console.WriteLine("ასეთი სიგრძის სახელი არ არის ლისტში!");
    }
}
else
{
  Console.WriteLine("არასწორი ფორმატი");  
}



#endregion */ // LinQ length