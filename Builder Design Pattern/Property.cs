namespace Builder_Design_Pattern;

//Product
public class Property
{
    public string Address { get; set; } = string.Empty;
    public int NoOfRooms { get; set; }
    public int NoOfBathrooms { get; set; }
    public bool HasPool { get; set; }
    public decimal Price { get; set; }
    public double TotalArea { get; set; }
    public string OwnerMobile { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
