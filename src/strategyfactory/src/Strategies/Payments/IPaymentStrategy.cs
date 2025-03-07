namespace Strategies.Payments;

public interface IPaymentStrategy
{
    bool CanUseStrategy(string paymentType);
    void HandlePayment();
}
