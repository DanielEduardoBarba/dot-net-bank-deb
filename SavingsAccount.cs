
public class SavingsAccount: BankAccount{

    public SavingsAccount(string name, double initialBalance) : base(name, initialBalance){
        deposit(20);
    }
}