namespace State_Design_Pattern;

public class Account
{
    public int PIN { get; private set; }
    public decimal Balance { get; private set; }

    public Account(int pin)
    {
        PIN = pin;
        Balance = 0m;
    }

    public void Deposite(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    public decimal GetBalance()
    {
        return Balance;
    }
}
