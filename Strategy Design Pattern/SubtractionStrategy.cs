namespace Strategy_Design_Pattern;

public class SubtractionStrategy : ICalculationStrategy
{
    public double Calculate(double value1, double value2)
    {
        return Math.Abs(value1 - value2);
    }
}
