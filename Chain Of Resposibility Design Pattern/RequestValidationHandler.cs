namespace Chain_Of_Resposibility_Design_Pattern;

public class RequestValidationHandler : RequestHandler
{
    public override void HandleRequest(int requestAmount)
    {
        if (requestAmount > 0)
            CallNext(requestAmount);
        else
            Console.WriteLine("Invalid amount!");
    }
}
