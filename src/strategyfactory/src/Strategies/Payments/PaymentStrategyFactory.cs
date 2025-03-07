namespace Strategies.Payments;

public sealed class PaymentStrategyFactory : IPaymentStrategyFactory
{
    private readonly IEnumerable<IPaymentStrategy> _paymentStrategies;

    public PaymentStrategyFactory(IEnumerable<IPaymentStrategy> paymentStrategies)
    {
        _paymentStrategies = paymentStrategies;
    }

    public IPaymentStrategy GetPaymentStrategy(string paymentType)
    {
        foreach (IPaymentStrategy paymentStrategy in _paymentStrategies)
        {
            if (paymentStrategy.CanUseStrategy(paymentType))
                return paymentStrategy;
        }

        throw new ArgumentOutOfRangeException($"No strategy could be found for payment type '{paymentType}'.");
    }
}
