namespace JacobMath;

public class MathStuff
{
    public int num1 { get; set; }
    public int num2 { get; set;}
    public string operation { get; set; }

    public MathStuff(int num1, int num2, string operation)
    {
        this.num1 = num1;
        this.num2 = num2;
        this.operation = operation;

        switch (operation)
        {
            case "+":
                Console.WriteLine(AddInts(num1, num2));
                break;
            case "-":
                Console.WriteLine(SubtractInts(num1, num2));
                break;
            case "*":
                Console.WriteLine(MultiplyInts(num1, num2));
                break;
            case "/":
                Console.WriteLine(DivideInts(num1, num2));
                break;
            default:
                break;
        }
    }

    public int AddInts(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }

    public int SubtractInts(int num1, int num2)
    {
        return num1 - num2;
    }

    public int MultiplyInts(int num1, int num2)
    {
        return num1 * num2;
    }

    public int DivideInts(int num1, int num2)
    {
        return num1 / num2;
    }
}