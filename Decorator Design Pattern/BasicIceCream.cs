using System.Reflection.Metadata.Ecma335;

namespace Decorator_Design_Pattern;

public class BasicIceCream : IIceCream
{
    public decimal CalculateCost() => 4.5m;

    public string Description() => " Basic Ice Cream";
}
