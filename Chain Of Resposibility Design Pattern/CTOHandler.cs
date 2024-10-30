namespace Chain_Of_Resposibility_Design_Pattern;

public class CTOHandler : RequestHandler
{
    public override void HandleRequest(int requestAmount)
    {
        if (requestAmount <= 3000)
            Console.WriteLine("Request accepted by CTO");
        else
            CallNext(requestAmount);
    }
}
