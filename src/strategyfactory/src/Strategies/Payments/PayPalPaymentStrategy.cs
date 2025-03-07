namespace Strategies.Payments;

public sealed class PayPalPaymentStrategy : PaymentStrategyBase
{
    protected override string PaymentType => "PayPal";

    public override void HandlePayment()
    {
        Console.WriteLine("Handling payment with PayPal...");
        Console.WriteLine("Sending payment information to PayPal...");
        Console.WriteLine("Redirecting to PayPal payment page...");
        Console.WriteLine("Payment successfull");
    }
}
