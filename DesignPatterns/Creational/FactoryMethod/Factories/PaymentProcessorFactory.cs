using DesignPatterns.Creational.FactoryMethod.Payment;
using DesignPatterns.Creational.FactoryMethod.Processors;

namespace DesignPatterns.Creational.FactoryMethod.Factories;

public abstract class PaymentProcessorFactory
{
    public async Task ProcessAsync(PaymentEntity payment)
    {
        var processor = CreateProcessor(payment);
        await processor.ProcessPayment(payment);
    }

    protected abstract IPaymentProcessor CreateProcessor(PaymentEntity payment);
}