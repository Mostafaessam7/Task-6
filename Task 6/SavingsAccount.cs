using System;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount(
        string name = "Unnamed Savings Account",
        double balance = 0.0,
        double interestRate = 0.0)
        : base(name, balance)
    {
        InterestRate = interestRate;
    }

    public override bool Deposit(double amount)
    {
        amount += amount * (InterestRate / 100);

        return base.Deposit(amount);
    }

    public override string ToString()
    {
        return $"[Savings Account: {Name}: {Balance}, Interest: {InterestRate}%]";
    }
}