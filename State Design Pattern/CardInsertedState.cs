namespace State_Design_Pattern;

public class CardInsertedState : IState
{
    public ATM_Machine atm;

    public CardInsertedState(ATM_Machine _atm)
    {
        atm = _atm;
    }

    public void DepositeCash(decimal amount)
    {
        Console.WriteLine("Enter valid PIN firstly!");
    }

    public void EjectCard()
    {
        Console.WriteLine("Card ejected, please hold it!");
        atm.SetATMState(atm.NoCardInsertedState);
    }

    public void EnterPin(int pin)
    {
        if (pin == atm.Account.PIN)
        {
            Console.WriteLine("Correct PIN.");
            atm.SetATMState(atm.CorrectPinState);
        }
        else
        {
            Console.WriteLine("Invalid PIN!");
        }
    }

    public void InsertCard()
    {
        Console.WriteLine("There is already card inserted!");
    }

    public void WithdrawCash(decimal amount)
    {
        Console.WriteLine("Enter valid PIN firstly!");
    }
}
