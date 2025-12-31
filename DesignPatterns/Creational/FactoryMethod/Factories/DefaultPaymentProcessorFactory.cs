using DesignPatterns.Creational.FactoryMethod.Payment;
using DesignPatterns.Creational.FactoryMethod.Processors;

namespace DesignPatterns.Creational.FactoryMethod.Factories;

public class DefaultPaymentProcessorFactory : PaymentProcessorFactory
{
    protected override IPaymentProcessor CreateProcessor(PaymentEntity payment)
        => payment.Type switch
        {
            PaymentType.CreditCard => new CreditCardProcessor(),
            PaymentType.DebitCard => new DebitCardProcessor(),
            _ => throw new NotSupportedException("Payment type not supported.")
        };
}