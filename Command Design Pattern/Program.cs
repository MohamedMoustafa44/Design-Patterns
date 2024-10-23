namespace Command_Design_Pattern;

public class Program
{
    static void Main(string[] args)
    {
        //Make Receiver
        TV tv = new TV();

        //Make your concrete commands
        ICommand turnOn = new TurnOnCommand(tv);
        ICommand turnOff = new TurnOffCommand(tv);
        ICommand channelUp = new ChannelUpCommand(tv);
        ICommand channelDown = new ChannelDownCommand(tv);

        //Create an invoker
        RemoteControl remoteControl = new RemoteControl();

        //Invoke commands
        remoteControl.SetCommand(turnOn);
        remoteControl.PressButton();


        remoteControl.SetCommand(channelUp);
        remoteControl.PressButton();

        remoteControl.SetCommand(channelDown);
        remoteControl.PressButton();

        remoteControl.PressUndo(); 

        remoteControl.SetCommand(turnOff);
        remoteControl.PressButton();

    }
}
