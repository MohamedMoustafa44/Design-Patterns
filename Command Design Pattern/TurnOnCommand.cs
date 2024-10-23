namespace Command_Design_Pattern;

//Concrete Command
public class TurnOnCommand : ICommand
{
    private TV _tv;

    public TurnOnCommand(TV tv)
    {
        _tv = tv;
    }

    public bool CanExecute() => !_tv.IsOn;

    public void Execute()
    {
        if (!CanExecute())
            return;

        _tv.TurnOn();
    }

    public void Undo()
    {
        if (CanExecute())
            return;

        _tv.TurnOff();
    }
}
