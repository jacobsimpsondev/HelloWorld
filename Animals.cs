public class Animal
{
    public string Name { get; set; } = "";

    public virtual void Speak()
    {
        Console.WriteLine("The animal is speaking");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}