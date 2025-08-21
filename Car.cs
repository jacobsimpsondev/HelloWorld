
// abstract classes are used as shared/starter code for other classes

abstract class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;

        Console.WriteLine($"So you are talking about a {year} {make} {model}");
        Drive();
    }

    public virtual void Drive()
    {
        Console.WriteLine("This is set because of the interface!");
    }
}

class Truck : Car
{
    public Truck(string make, string model, int year)
        : base(make, model, year) // pass args to Car’s constructor
    {
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving a truck: {Year} {Make} {Model}");
    }
}
