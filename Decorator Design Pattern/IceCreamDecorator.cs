namespace Decorator_Design_Pattern;

public abstract class IceCreamDecorator : IIceCream
{
    public IIceCream IceCream;

    protected IceCreamDecorator(IIceCream iceCream)
    {
        IceCream = iceCream;
    }

    public virtual decimal CalculateCost() => IceCream.CalculateCost();

    public virtual string Description() => IceCream.Description();
}
