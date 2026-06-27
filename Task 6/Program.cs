using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accounts
        var accounts = new List<Account>();
        accounts.Add(new Account());
        accounts.Add(new Account("Larry"));
        accounts.Add(new Account("Moe", 2000));
        accounts.Add(new Account("Curly", 5000));

        Console.WriteLine("\n= 1");

        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Withdraw(accounts, 2000);

        // Savings
        var savAccounts = new List<SavingsAccount>();
        savAccounts.Add(new SavingsAccount());
        savAccounts.Add(new SavingsAccount("Superman"));
        savAccounts.Add(new SavingsAccount("Batman", 2000));
        savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

        Console.WriteLine("\n= 2");

        AccountUtil.Display(savAccounts);
        AccountUtil.Deposit(savAccounts, 1000);
        AccountUtil.Withdraw(savAccounts, 2000);

        // Checking
        var checAccounts = new List<CheckingAccount>();
        checAccounts.Add(new CheckingAccount());
        checAccounts.Add(new CheckingAccount("Larry2"));
        checAccounts.Add(new CheckingAccount("Moe2", 2000));
        checAccounts.Add(new CheckingAccount("Curly2", 5000));

        Console.WriteLine("\n= 3");

        AccountUtil.Display(checAccounts);
        AccountUtil.Deposit(checAccounts, 1000);
        AccountUtil.Withdraw(checAccounts, 2000);
        AccountUtil.Withdraw(checAccounts, 2000);

        // Trust
        var trustAccounts = new List<TrustAccount>();
        trustAccounts.Add(new TrustAccount());
        trustAccounts.Add(new TrustAccount("Superman2"));
        trustAccounts.Add(new TrustAccount("Batman2", 2000));
        trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

        Console.WriteLine("\n= 4");

        AccountUtil.Display(trustAccounts);
        AccountUtil.Deposit(trustAccounts, 1000);
        AccountUtil.Deposit(trustAccounts, 6000);
        AccountUtil.Withdraw(trustAccounts, 2000);
        AccountUtil.Withdraw(trustAccounts, 3000);
        AccountUtil.Withdraw(trustAccounts, 500);

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}