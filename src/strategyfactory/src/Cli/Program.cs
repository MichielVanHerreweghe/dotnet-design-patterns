using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Strategies;
using Strategies.Payments;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddApplicationStrategiesAndFactories();
    })
    .Build();

IPaymentStrategyFactory paymentStrategyFactory = host.Services
    .GetRequiredService<IPaymentStrategyFactory>();

Console.WriteLine("Hello! How would you like to pay?\n");
Console.WriteLine("Payment Method:");
string? paymentType = Console.ReadLine();

if (string.IsNullOrWhiteSpace(paymentType))
    throw new ArgumentNullException(nameof(paymentType));

IPaymentStrategy paymentStrategy = paymentStrategyFactory.GetPaymentStrategy(paymentType);

paymentStrategy.HandlePayment();