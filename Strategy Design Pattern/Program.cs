namespace Strategy_Design_Pattern;

internal class Program
{
    static void Main(string[] args)
    {
        CalculationContext context = new(new AdditionStrategy());
        Console.WriteLine("Addition result: " + context.Calculate(10.5, 14.4));
        context.UpdateStrategy(new SubtractionStrategy());
        Console.WriteLine("Subtraction result: " + context.Calculate(10.5, 14.4));
        context.UpdateStrategy(new MultiplicationStrategy());
        Console.WriteLine("Multiplication result: " + context.Calculate(8, 2));
        context.UpdateStrategy(new DivisionStrategy());
        Console.WriteLine("Multiplication result: " + context.Calculate(8, 2));
    }
}
