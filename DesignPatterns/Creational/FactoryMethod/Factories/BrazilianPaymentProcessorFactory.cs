using DesignPatterns.Creational.FactoryMethod.Payment;
using DesignPatterns.Creational.FactoryMethod.Processors;

namespace DesignPatterns.Creational.FactoryMethod.Factories;

public class BrazilianPaymentProcessorFactory : PaymentProcessorFactory
{
    protected override IPaymentProcessor CreateProcessor(PaymentEntity payment)
        => payment.Type switch
        {
            PaymentType.Pix => new PixProcessor(),
            PaymentType.CreditCard => new CreditCardProcessor(),
            PaymentType.DebitCard => new DebitCardProcessor(),
            _ => throw new NotSupportedException("Payment type not supported.")
        };
}