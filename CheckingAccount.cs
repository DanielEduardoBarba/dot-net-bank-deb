
public class CheckingAccount: BankAccount{

    public CheckingAccount(string name, double initialBalance) : base(name, initialBalance){
        deposit(100);
    }
}