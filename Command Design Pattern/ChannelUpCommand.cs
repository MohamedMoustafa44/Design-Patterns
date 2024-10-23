namespace Command_Design_Pattern;

//Concrete Command
public class ChannelUpCommand : ICommand
{
    private TV _tv;

    public ChannelUpCommand(TV tv)
    {
        _tv = tv;
    }

    public bool CanExecute() => _tv.IsOn;

    public void Execute()
    {
        if (!CanExecute())
            return;

        _tv.ChannelUp();
    }

    public void Undo()
    {
        if (!CanExecute())
            return;

        _tv.ChannelDown();
    }
}
