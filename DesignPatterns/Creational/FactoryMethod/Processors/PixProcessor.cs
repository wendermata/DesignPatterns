using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.FactoryMethod.Processors;

public class PixProcessor : IPaymentProcessor
{
    public Task<bool> ProcessPayment(PaymentEntity payment)
    {
        Console.WriteLine("This operation is supported exclusively by brazilian banks.");
        Console.WriteLine($"Processing a Pix Transfer Operation of {payment.Value:C}");
        Console.WriteLine("Payment processed successfully.");
        payment.IsProcessed = true;
        return Task.FromResult(payment.IsProcessed);
    }
}