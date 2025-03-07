namespace Strategies.Payments;

public abstract class PaymentStrategyBase : IPaymentStrategy
{
    protected abstract string PaymentType { get; }

    public bool CanUseStrategy(string paymentType) => paymentType.Contains(PaymentType, StringComparison.OrdinalIgnoreCase);

    public abstract void HandlePayment();
}
