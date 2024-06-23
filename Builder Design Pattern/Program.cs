namespace Builder_Design_Pattern;

//Director Class
public class Program
{
    static void Main(string[] args)
    {
        var property = new PropertyBuilder()
            .SetAddres("Alexandria")
            .SetNoOfRooms(3)
            .SetNoOfBathrooms(2)
            .IsHasPool(false)
            .SetArea(145)
            .SetOwnerMobile("01279115899")
            .SetPrice(800_000)
            .SetDescription("This is an apartment 145 m2, for sale")
            .Build();
    }
}