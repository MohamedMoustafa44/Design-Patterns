namespace Command_Design_Pattern;

//Concrete Command
public class TurnOffCommand : ICommand
{
    private TV _tv;

    public TurnOffCommand(TV tv)
    {
        _tv = tv;
    }

    public bool CanExecute() => _tv.IsOn;

    public void Execute()
    {
        if (!CanExecute())
            return;

        _tv.TurnOff();
    }

    public void Undo()
    {
        if (CanExecute())
            return;

        _tv.TurnOn();
    }
}
