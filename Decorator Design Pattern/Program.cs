namespace Decorator_Design_Pattern;

public class Program
{
    static void Main(string[] args)
    {
        IIceCream order = new BasicIceCream();
        order = new Sprinkles(order);
        order = new Chocolate(order);
        order = new Strawberry(order);

        Console.WriteLine($"Order: {order.Description()} | Price: {order.CalculateCost()}");
    }
}
