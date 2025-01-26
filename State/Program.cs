namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var account = new BankAccount(50);

            account.Withdraw(100);

            account.Deposit(200);

            account.Deposit(1000);

            account.Deposit(1);



        }
    }
}
