// See https://aka.ms/new-console-template for more information

BankAccount newaccount = new BankAccount();

if(newaccount.typeOfAccount == "checking") newaccount.balance += 100;

Console.WriteLine(newaccount.customerName+"'s balance is " + newaccount.balance);
