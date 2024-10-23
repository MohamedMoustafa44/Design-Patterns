namespace Command_Design_Pattern;

//The Revceiver
public class TV
{
    public bool IsOn { get; private set; } = false;
    public int ChannelNumber { get; private set; } = 1;
    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("The T.V is turned on.");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("The T.V is turned off.");
    }

    public void ChannelUp()
    {
        Console.WriteLine("You pressed arrow up button.");
        ChannelNumber++;
    }

    public void ChannelDown()
    {
        Console.WriteLine("You pressed arrow down button.");
        ChannelNumber--;
    }
}
