namespace State_Design_Pattern;

public class NoCardInsertedState : IState
{
    public ATM_Machine atm;
    public NoCardInsertedState(ATM_Machine _atm)
    {
        atm = _atm;
    }
    public void DepositeCash(decimal amount)
    {
        Console.WriteLine("There is no card inserted!");
    }

    public void EjectCard()
    {
        Console.WriteLine("There is no card inserted!");
    }

    public void EnterPin(int pin)
    {
        Console.WriteLine("There is no card inserted!");
    }

    public void InsertCard()
    {
        Console.WriteLine("Card inserted successfully!");
        atm.SetATMState(atm.CardInsertedState);
    }

    public void WithdrawCash(decimal amount)
    {
        Console.WriteLine("There is no card inserted!");
    }
}
