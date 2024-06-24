namespace Decorator_Design_Pattern;

public class Program
{
    static void Main(string[] args)
    {
        IIceCream order1 = new BasicIceCream();
        order1 = new Sprinkles(order1);
        order1 = new Chocolate(order1);
        order1 = new Strawberry(order1);

        Console.WriteLine($"Order: {order1.Description()} | Price: {order1.CalculateCost()}");

        IIceCream order2 = new NitrogenIceCream();
        order2 = new Strawberry(order2);

        Console.WriteLine($"Order: {order2.Description()} | Price: {order2.CalculateCost()}");
    }
}
