using FizzBuzz.Console.Interfaces;
using FizzBuzz.Console.Types;
using FizzBuzz.Console.Types.Rules;

Console.WriteLine("***FizzBuzz Game***");
int rangeStartNumber, rangeEndNumber;

while (true)
{
    Console.Write("Enter the range start number: ");
    var rangeStartInput = Console.ReadLine();
    if (int.TryParse(rangeStartInput, out rangeStartNumber) && rangeStartNumber >= 1 && rangeStartNumber <= 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid start number. Please enter a valid integer between 1 and 100.");
    }
}

while (true)
{
    Console.Write("Enter the range end number: ");
    var rangeEndInput = Console.ReadLine();
    if (int.TryParse(rangeEndInput, out rangeEndNumber) && rangeEndNumber >= 1 && rangeEndNumber <= 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid end number. Please enter a valid integer. Please enter a valid integer between 1 and 100.");
    }
}

var fizzBuzzRules = new IFizzBuzzRule[] {
    new FizzBuzzRule(),
    new FizzRule(),
    new BuzzRule(),
    new DefaultRule()
};

var fizzBuzzGame = new FizzBuzzGame(
    rangeStartNumber,
    rangeEndNumber,
    fizzBuzzRules
);
var fizzBuzzGameOutputs = fizzBuzzGame.GetRangeOutput();

PrintFizzBuzzGameOutputs(fizzBuzzGameOutputs);




static void PrintFizzBuzzGameOutputs(List<string> fizzBuzzGameOutputs)
{
    Console.WriteLine("Game Output:");
    for (var i = 0; i < fizzBuzzGameOutputs.Count; i++)
    {
        if (i != 0 && i % 5 == 0) Console.WriteLine();

        Console.Write(fizzBuzzGameOutputs[i] + " ");
    }

    Console.WriteLine();
}