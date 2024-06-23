namespace Builder_Design_Pattern;

//Product Builder
public class PropertyBuilder
{
    private Property _property = new();

    public PropertyBuilder SetAddres(string address)
    {
        _property.Address = address;
        return this;
    }

    public PropertyBuilder SetNoOfRooms(int noOfRooms)
    {
        _property.NoOfRooms = noOfRooms;
        return this;
    }

    public PropertyBuilder SetNoOfBathrooms(int noOfBathrooms)
    {
        _property.NoOfBathrooms = noOfBathrooms;
        return this;
    }

    public PropertyBuilder IsHasPool(bool hasPool)
    {
        _property.HasPool = hasPool;
        return this;
    }

    public PropertyBuilder SetPrice(decimal price)
    {
        _property.Price = price;
        return this;
    }

    public PropertyBuilder SetArea(double area)
    {
        _property.TotalArea = area;
        return this;
    }

    public PropertyBuilder SetOwnerMobile(string mobile)
    {
        _property.OwnerMobile = mobile;
        return this;
    }

    public PropertyBuilder SetDescription(string description)
    {
        _property.Description = description;
        return this;
    }

    public Property Build()
    {
        return _property;
    }
}
