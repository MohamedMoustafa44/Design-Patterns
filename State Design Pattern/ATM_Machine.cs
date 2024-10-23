namespace State_Design_Pattern;

public class ATM_Machine
{
    public IState NoCardInsertedState { get; private set; }
    public IState CardInsertedState { get; private set; }
    public IState CorrectPinState { get; private set; }
    public IState CurrentState;

    public Account Account { get; set; }

    public ATM_Machine()
    {
        NoCardInsertedState = new NoCardInsertedState(this);
        CardInsertedState = new CardInsertedState(this);
        CorrectPinState = new ValidPINState(this);
        Account = null!;

        CurrentState = NoCardInsertedState;
    }

    public void SetATMState(IState state)
    {
        CurrentState = state;
    }

    public void InsertCard(Account account)
    {
        Account = account;
        CurrentState.InsertCard();
    }

    public void EjectCard()
    {
        Account = null!;
        CurrentState.EjectCard();
    }

    public void EnterPin(int pin)
    {
        CurrentState.EnterPin(pin);
    }

    public void WithdrawCash(decimal amount)
    {
        CurrentState.WithdrawCash(amount);
    }

    public void DepositeCash(decimal amount)
    {
        CurrentState.DepositeCash(amount);
    }

}
