namespace Decorator_Design_Pattern;

public class Strawberry : IceCreamDecorator
{
    public Strawberry(IIceCream iceCream) : base(iceCream)
    {
    }

    public override decimal CalculateCost() => base.CalculateCost() + 0.75m;
    public override string Description() => $"{base.Description()} + Strawberry";
}
