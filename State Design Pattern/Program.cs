namespace State_Design_Pattern;

internal class Program
{
    static void Main(string[] args)
    {
        Account account = new Account(1234);

        ATM_Machine machine = new ATM_Machine();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("0. Eject card");
            Console.WriteLine("1. Insert card");
            Console.WriteLine("2. Witdraw amount");
            Console.WriteLine("3. Deposite amount");
            int choice = int.Parse(Console.ReadLine()!);
            switch(choice)
            {
                case 0:
                    machine.EjectCard();
                    exit = true;
                    break;
                case 1:
                    machine.InsertCard(account);
                    Console.WriteLine("Enter your valid PIN.");
                    var pin = int.Parse(Console.ReadLine()!);
                    machine.EnterPin(pin);
                    break;
                case 2:
                    Console.WriteLine("Enter amount to withdraw:");
                    decimal amount = decimal.Parse(Console.ReadLine()!);
                    machine.WithdrawCash(amount);
                    break;
                case 3:
                    Console.WriteLine("Enter amount to deposite:");
                    amount = decimal.Parse(Console.ReadLine()!);
                    machine.DepositeCash(amount);
                    break;
                }
            }
        }
    }
