using System;

public class CheckingAccount : Account
{
    private const double WithdrawalFee = 1.50;

    public CheckingAccount(
        string name = "Unnamed Checking Account",
        double balance = 0.0)
        : base(name, balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        return base.Withdraw(amount + WithdrawalFee);
    }

    public override string ToString()
    {
        return $"[Checking Account: {Name}: {Balance}]";
    }
}