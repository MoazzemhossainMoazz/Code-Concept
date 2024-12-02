abstract class Payment
{
    public abstract void ProcessPayment(double amount);

    public void PrintReceipt()
    {
        Console.WriteLine("Payment receipt has been printed.");
    }
}
class CreditCardPayment : Payment
{
    public override void ProcessPayment(Double amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}...");
    }
}
class PayPalPayment: Payment
{
    public override void ProcessPayment(Double amount)
    {
        Console.WriteLine($"Processing Paypal payment of ${amount}...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Payment newCreditPayment = new CreditCardPayment();
        Payment newPaypalPayment = new PayPalPayment();

        newCreditPayment.ProcessPayment(100.3);
        newCreditPayment.PrintReceipt();

        Console.WriteLine();
        newPaypalPayment.ProcessPayment(50.3);
        newPaypalPayment.PrintReceipt();
    }
}