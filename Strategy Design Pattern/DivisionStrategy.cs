namespace Strategy_Design_Pattern;

public class DivisionStrategy : ICalculationStrategy
{
    public double Calculate(double value1, double value2)
    {
        return value1 / value2;
    }
}
