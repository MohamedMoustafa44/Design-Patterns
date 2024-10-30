namespace Chain_Of_Resposibility_Design_Pattern;

public abstract class RequestHandler : IRequestHandler
{
    private IRequestHandler _handler;
    public abstract void HandleRequest(int requestAmount);
    

    public void SetNextHandler(IRequestHandler next)
    {
        _handler = next;
    }

    protected void CallNext(int requestAmount)
    {
        if (_handler != null)
            _handler.HandleRequest(requestAmount);
    }
}
