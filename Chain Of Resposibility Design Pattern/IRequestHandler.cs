namespace Chain_Of_Resposibility_Design_Pattern;

public interface IRequestHandler
{
    void HandleRequest(int requestAmount);
    void SetNextHandler(IRequestHandler next);
}