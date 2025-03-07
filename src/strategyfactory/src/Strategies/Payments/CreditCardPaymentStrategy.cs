namespace Strategies.Payments;

public sealed class CreditCardPaymentStrategy : PaymentStrategyBase
{
    protected override string PaymentType => "CreditCard";

    public override void HandlePayment()
    {
        Console.WriteLine("Handling payment by creditcard...");
        Console.WriteLine("Payment successfull");
    }
}
