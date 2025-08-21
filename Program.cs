using Calculator;
using JacobMath;

public class Greetings
{
    public string HelloThere(string name)
    {
        return $"Hello there, {name}.";
    }
}

public class ProgramTest
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Use +, -, *, /, to select the math function.");
        // string operation = Console.ReadLine();
        // if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
        // {
        //     MathStuff calc = new MathStuff(25, 5, operation);
        // }
        // else
        // {
        //     Console.WriteLine("Select an appropriate function");
        // }
        TipCalculator tipCalculator = new TipCalculator();
        string test1 = tipCalculator.getBillAmount();
        string test2 = tipCalculator.getTipPercent();
        tipCalculator.calculateTotalBill(test1, test2);
    }

    // public static void Main(string[] args)
    // {
    //     MathStuff testMath = new MathStuff();
    //     Greetings messages = new Greetings();

    //     Console.WriteLine(testMath.AddInts(16, 9));
    //     Console.WriteLine(testMath.SubtractInts(16, 9));
    //     Console.WriteLine(testMath.MultiplyInts(4, 9));
    //     Console.WriteLine(testMath.DivideInts(50, 5));

    //     Console.WriteLine(messages.HelloThere("Jacob"));

    //     int myAge = 43;
    //     double hourlyRate = 45.00;
    //     string myName = "Jacob";
    //     bool expert = false;

    //     int testNumber = 10;
    //     int otherNumber = 1;

    //     Console.WriteLine(myAge);
    //     Console.WriteLine(hourlyRate);
    //     Console.WriteLine(myName);
    //     Console.WriteLine(expert);

    //     if (myAge > 33)
    //     {
    //         Console.WriteLine($"{myName} is getting older");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"{myName} used to be this age");
    //     }

    //     switch (myName)
    //     {
    //         case "jacob":
    //             Console.WriteLine("You need to uppercase your name");
    //             break;
    //         case "Jacob":
    //             Console.WriteLine("This is what i wanted");
    //             break;
    //         default:
    //             Console.WriteLine("Something to say??");
    //             break;
    //     }

    //     for (int i = 1; i <= testNumber; i++)
    //     {
    //         Console.WriteLine($"Line {i}");
    //     }

    //     while (otherNumber <= testNumber)
    //     {
    //         if (otherNumber % 2 != 0)
    //         {
    //             Console.WriteLine($"Odd #: {otherNumber}");
    //         }
    //         otherNumber++;
    //     }
    // }
}

