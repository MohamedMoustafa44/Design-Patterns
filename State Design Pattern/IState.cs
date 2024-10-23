namespace State_Design_Pattern;

public interface IState
{
    void InsertCard();
    void EjectCard();
    void EnterPin(int pin);
    void WithdrawCash(decimal amount);
    void DepositeCash(decimal amount);
}
