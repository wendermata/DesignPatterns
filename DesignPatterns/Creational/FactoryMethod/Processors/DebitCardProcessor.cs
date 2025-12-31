using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.FactoryMethod.Processors;

public class DebitCardProcessor : IPaymentProcessor
{
    public Task<bool> ProcessPayment(PaymentEntity payment)
    {
        Console.WriteLine($"Processing a Debit Card operation of {payment.Value:C}");
        Console.WriteLine("Payment processed successfully.");
        payment.IsProcessed = true;
        return Task.FromResult(payment.IsProcessed);
    }
}