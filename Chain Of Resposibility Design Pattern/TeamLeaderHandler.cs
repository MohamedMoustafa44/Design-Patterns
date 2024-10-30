namespace Chain_Of_Resposibility_Design_Pattern;

public class TeamLeaderHandler : RequestHandler
{
    public override void HandleRequest(int requestAmount)
    {
        if (requestAmount <= 2000)
            Console.WriteLine("Request accepted by Team Leaders");
        else
            CallNext(requestAmount);
    }
}
