using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        ////(1) Main Task

        //// Accounts
        //var accounts = new List<Account>();
        //accounts.Add(new Account());
        //accounts.Add(new Account("Larry"));
        //accounts.Add(new Account("Moe", 2000));
        //accounts.Add(new Account("Curly", 5000));

        //Console.WriteLine("\n= 1");

        //AccountUtil.Display(accounts);
        //AccountUtil.Deposit(accounts, 1000);
        //AccountUtil.Withdraw(accounts, 2000);

        //// Savings
        //var savAccounts = new List<SavingsAccount>();
        //savAccounts.Add(new SavingsAccount());
        //savAccounts.Add(new SavingsAccount("Superman"));
        //savAccounts.Add(new SavingsAccount("Batman", 2000));
        //savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

        //Console.WriteLine("\n= 2");

        //AccountUtil.Display(savAccounts);
        //AccountUtil.Deposit(savAccounts, 1000);
        //AccountUtil.Withdraw(savAccounts, 2000);

        //// Checking
        //var checAccounts = new List<CheckingAccount>();
        //checAccounts.Add(new CheckingAccount());
        //checAccounts.Add(new CheckingAccount("Larry2"));
        //checAccounts.Add(new CheckingAccount("Moe2", 2000));
        //checAccounts.Add(new CheckingAccount("Curly2", 5000));

        //Console.WriteLine("\n= 3");

        //AccountUtil.Display(checAccounts);
        //AccountUtil.Deposit(checAccounts, 1000);
        //AccountUtil.Withdraw(checAccounts, 2000);
        //AccountUtil.Withdraw(checAccounts, 2000);

        //// Trust
        //var trustAccounts = new List<TrustAccount>();
        //trustAccounts.Add(new TrustAccount());
        //trustAccounts.Add(new TrustAccount("Superman2"));
        //trustAccounts.Add(new TrustAccount("Batman2", 2000));
        //trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

        //Console.WriteLine("\n= 4");

        //AccountUtil.Display(trustAccounts);
        //AccountUtil.Deposit(trustAccounts, 1000);
        //AccountUtil.Deposit(trustAccounts, 6000);
        //AccountUtil.Withdraw(trustAccounts, 2000);
        //AccountUtil.Withdraw(trustAccounts, 3000);
        //AccountUtil.Withdraw(trustAccounts, 500);

        //Console.WriteLine();
        //Console.WriteLine("Press any key to exit...");
        //Console.ReadKey();



        //(2) Search Task

        //////////////////(1)

        //static void CheckDuplicates(List<int> numbers)
        //{
        //    HashSet<int> seen = new HashSet<int>();

        //    foreach (int num in numbers)
        //    {
        //        if (seen.Contains(num))
        //        {
        //            throw new Exception("Duplicate number found: " + num);
        //        }

        //        seen.Add(num);
        //    }
        //}

        //try
        //{
        //    List<int> numbers = new List<int>();

        //    Console.Write("Enter how many numbers: ");
        //    int count = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.Write("Enter number " + (i + 1) + ": ");
        //        int number = int.Parse(Console.ReadLine());
        //        numbers.Add(number);
        //    }

        //    CheckDuplicates(numbers);

        //    Console.WriteLine("No duplicate numbers found.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Exception: " + ex.Message);
        //}

        //////////////////(2)

        static void CheckVowels(string text)
        {
            string vowels = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    Console.WriteLine("The string contains vowels.");
                    return;
                }
            }

            throw new Exception("The string does not contain any vowels.");
        }

        try
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            CheckVowels(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }


    }
}