namespace Chain_Of_Resposibility_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of request that you want: ");
            var request = int.Parse(Console.ReadLine()!);

            var requestValidationHandler = new RequestValidationHandler();
            var employeeHandler = new EmployeeHandler();
            var teamLeaderHandler = new TeamLeaderHandler();
            var ctoHandler = new CTOHandler();
            var ceoHandler = new CEOHandler();

            requestValidationHandler.SetNextHandler(employeeHandler);
            employeeHandler.SetNextHandler(teamLeaderHandler);
            teamLeaderHandler.SetNextHandler(ctoHandler);
            ctoHandler.SetNextHandler(ceoHandler);

            requestValidationHandler.HandleRequest(request);



        }
    }
}
