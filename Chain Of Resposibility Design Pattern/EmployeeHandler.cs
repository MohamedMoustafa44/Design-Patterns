namespace Chain_Of_Resposibility_Design_Pattern;

public class EmployeeHandler : RequestHandler
{
    public override void HandleRequest(int requestAmount)
    {
        if (requestAmount <= 1000)
            Console.WriteLine("Request accepted by Employee");
        else
            CallNext(requestAmount);
    }
}
