internal class NewBaseType
{
    private static void Main(string[] args)
    {
        //BankAccount newaccount = new BankAccount();
        //BankAccount newaccount = new BankAccount("Arnold", 59.98, "checking");
       //CheckingAccount newaccount = new CheckingAccount("Arnold", 59.98);
        BankAccount newaccount = new SavingsAccount("Arnold", 500);

        newaccount.deposit(100);

        Console.WriteLine(newaccount.name + "'s balance is " + newaccount.getBalance() );
    }
}
