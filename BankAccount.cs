public class BankAccount
{
    public string name = "";
    private double balance = 0;

    //this is a default constructor
    public BankAccount(string newName, double initialBalance)
    {
        name = newName;
        balance = initialBalance;
    }

    public void deposit(double amount){
        if(amount>=0) balance += amount;
        else throw new Exception("no negative deposits allowed");
    }
    public double getBalance(){
        return balance;
    }

}