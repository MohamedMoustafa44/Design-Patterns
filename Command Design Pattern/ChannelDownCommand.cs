namespace Command_Design_Pattern;

//Concrete Command
public class ChannelDownCommand : ICommand
{
    private TV _tv;

    public ChannelDownCommand(TV tv)
    {
        _tv = tv;
    }

    public bool CanExecute() => _tv.IsOn;
    public void Execute()
    {
        if (!CanExecute())
            return;

        _tv.ChannelDown();
    }

    public void Undo()
    {
        if (!CanExecute())
            return;

        _tv.ChannelUp();
    }
}
