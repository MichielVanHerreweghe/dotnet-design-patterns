namespace Strategies.Payments;

public interface IPaymentStrategyFactory
{
    IPaymentStrategy GetPaymentStrategy(string paymentType);
}
