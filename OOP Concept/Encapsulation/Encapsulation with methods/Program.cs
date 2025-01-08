class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
        else
            throw new ArgumentException("Deposit amount must be positive");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            throw new ArgumentException("Invalid withdrawal amount.");
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        account.Withdraw(200);
        Console.WriteLine($"Balance: {account.GetBalance()}");
    }
}