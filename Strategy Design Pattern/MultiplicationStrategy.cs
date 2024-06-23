namespace Strategy_Design_Pattern;

public class MultiplicationStrategy : ICalculationStrategy
{
    public double Calculate(double value1, double value2)
    {
        return value1 * value2;
    }
}
