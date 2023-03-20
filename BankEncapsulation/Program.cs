namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            account.Deposit(300);
            account.Withdraw(50);
            account.GetBalance();
        }
    }
}
