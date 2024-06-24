namespace Decorator_Design_Pattern;

public class Chocolate : IceCreamDecorator
{
    public Chocolate(IIceCream iceCream) : base(iceCream)
    {
    }

    public override decimal CalculateCost() => base.CalculateCost() + 0.5m;

    public override string Description() => $"{base.Description()} + Chocolate";
}
