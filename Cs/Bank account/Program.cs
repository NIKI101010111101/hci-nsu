namespace Bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(1, 10000, 1234, "Pavel Ushkov");
            BankAccount account2 = new BankAccount();
        }
    }
}
