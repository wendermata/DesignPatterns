using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.FactoryMethod;

public class FactoryMethodPattern : IPattern
{
    private readonly PaymentEntity _creditPayment = new()
    {
        Value = 100,
        Type = PaymentType.CreditCard,
        IsProcessed = false
    };
    private readonly PaymentEntity _debitPayment = new()
    {
        Value = 200,
        Type = PaymentType.DebitCard,
        IsProcessed = false
    };
    private readonly PaymentEntity _pixPayment = new()
    {
        Value = 300,
        Type = PaymentType.Pix,
        IsProcessed = false
    };

    public void Run()
    {
        //creating a brazilian factory
        PaymentProcessorFactory factory = new BrazilianPaymentProcessorFactory();

        factory.ProcessAsync(_creditPayment);
        factory.ProcessAsync(_debitPayment);
        factory.ProcessAsync(_pixPayment);
        
        //now setting as a default factory
        factory = new DefaultPaymentProcessorFactory();
        
        factory.ProcessAsync(_creditPayment);
        factory.ProcessAsync(_debitPayment);
        
        //this line will throw an error 'cause defaultFactory doesnt support pix payment
        factory.ProcessAsync(_pixPayment);
    }
}