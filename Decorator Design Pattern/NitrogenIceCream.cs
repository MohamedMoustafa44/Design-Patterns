namespace Decorator_Design_Pattern;

public class NitrogenIceCream : IIceCream
{
    public decimal CalculateCost() => 5.0m;

    public string Description() => "Nitrogen Ice Cream";
}
