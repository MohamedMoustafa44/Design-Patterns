namespace Chain_Of_Resposibility_Design_Pattern;

public class CEOHandler : RequestHandler
{
    public override void HandleRequest(int requestAmount)
    {
        if (requestAmount > 3000)
            Console.WriteLine("Request accepted by CEO");
        else
            Console.WriteLine("There is something invalid");
    }
}
