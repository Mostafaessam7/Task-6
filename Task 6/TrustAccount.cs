using System;

public class TrustAccount : SavingsAccount
{
    private const int MaxWithdrawals = 3;
    private const double MaxWithdrawPercent = 0.20;
    private const double Bonus = 50.0;

    private int withdrawalCount;

    public TrustAccount(
        string name = "Unnamed Trust Account",
        double balance = 0.0,
        double interestRate = 0.0)
        : base(name, balance, interestRate)
    {
        withdrawalCount = 0;
    }

    public override bool Deposit(double amount)
    {
        if (amount >= 5000)
            amount += Bonus;

        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {
        if (withdrawalCount >= MaxWithdrawals)
            return false;

        if (amount > Balance * MaxWithdrawPercent)
            return false;

        bool result = base.Withdraw(amount);

        if (result)
            withdrawalCount++;

        return result;
    }

    public override string ToString()
    {
        return $"[Trust Account: {Name}: {Balance}, Interest: {InterestRate}%]";
    }
}