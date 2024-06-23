namespace Strategy_Design_Pattern;

public class CalculationContext
{
    public ICalculationStrategy _calculationStrategy { get; set; }

    public CalculationContext(ICalculationStrategy calculationStrategy)
    {
        _calculationStrategy = calculationStrategy;
    }

    public void UpdateStrategy(ICalculationStrategy calculationStrategy)
    {
        if (_calculationStrategy != calculationStrategy) _calculationStrategy = calculationStrategy;
    }

    public double Calculate(double value1, double value2)
    {
        return _calculationStrategy.Calculate(value1, value2);
    }
}
