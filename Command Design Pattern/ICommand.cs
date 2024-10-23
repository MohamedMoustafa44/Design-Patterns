namespace Command_Design_Pattern;

//Command Interface
public interface ICommand
{
    void Execute();
    bool CanExecute();
    void Undo();
}
