namespace Decorator_Design_Pattern;

public class Sprinkles : IceCreamDecorator
{
    public Sprinkles(IIceCream iceCream) : base(iceCream)
    {
    }

    public override decimal CalculateCost() => base.CalculateCost() + 0.25m;

    public override string Description() => $"{base.Description()} + Sprinkles";
}
