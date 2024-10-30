namespace State_Design_Pattern;

public class ValidPINState : IState
{
    public ATM_Machine atm;
    public ValidPINState(ATM_Machine _atm)
    {
        atm = _atm;
    }
    public void DepositeCash(decimal amount)
    {
        if (amount > 0)
        {
            Console.WriteLine("Please wait while transaction is proccessing...");
            Task.Delay(3000);
            atm.Account.Deposite(amount);
            Console.WriteLine("Your current balance is: " + atm.Account.GetBalance());
        }
        else
        {
            Console.WriteLine("Invalid amount!");
        }
    }

    public void EjectCard()
    {
        Console.WriteLine("Card ejected, please hold it!");
        atm.SetATMState(atm.NoCardInsertedState);
    }

    public void EnterPin(int pin)
    {
        Console.WriteLine("You entered valid PIN before!");
    }

    public void InsertCard()
    {
        Console.WriteLine("There is card already inserted!");
    }

    public void WithdrawCash(decimal amount)
    {
        if (atm.Account.Balance >= amount)
        {
            Console.WriteLine("Please wait while transaction is proccessing...");
            Task.Delay(3000);
            atm.Account.Withdraw(amount);
            Console.WriteLine("Your current balance is: " + atm.Account.GetBalance());
        }
        else
        {
            Console.WriteLine("Invalid ammout!");
        }
    }
}
