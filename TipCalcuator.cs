namespace Calculator;

public class TipCalculator
{
    public string getBillAmount()
    {
        Console.WriteLine("How much was your bill for?");
        string billAmount = Console.ReadLine();
        return billAmount;
    }

    public string getTipPercent()
    {
        Console.WriteLine("What percent would you like to tip?");
        string tipPercent = Console.ReadLine();
        return tipPercent;
    }

    public void calculateTotalBill(string billAmount, string tipPercent)
    {
        double totalBill = double.Parse(billAmount) * ((100 + double.Parse(tipPercent)) / 100);
        Console.WriteLine("Your Total Bill Due is:");
        Console.WriteLine($"${Math.Round(totalBill, 2)}");
    }
}