using Microsoft.Extensions.DependencyInjection;
using Strategies.Payments;

namespace Strategies;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationStrategiesAndFactories(this IServiceCollection services)
    {
        services.AddStrategies();
        services.AddStrategyFactories();

        return services;
    }

    private static void AddStrategyFactories(this IServiceCollection services)
    {
        services.AddScoped<IPaymentStrategyFactory, PaymentStrategyFactory>();
    }

    private static void AddStrategies(this IServiceCollection services)
    {
        services.AddPaymentStrategies();
    }

    private static void AddPaymentStrategies(this IServiceCollection services)
    {
        services.AddScoped<IPaymentStrategy, CreditCardPaymentStrategy>();
        services.AddScoped<IPaymentStrategy, PayPalPaymentStrategy>();
    }
}
