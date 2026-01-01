using DesignPatterns.Creational.AbstractFactory.Refunds;
using DesignPatterns.Creational.AbstractFactory.Taxes;
using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class InternationalOperationFactory(PaymentEntity paymentEntity) : IPaymentOperationFactory
{
    private PaymentEntity PaymentEntity { get; set; } = paymentEntity;

    public PaymentProcessorFactory CreatePaymentProcessorFactory() => new DefaultPaymentProcessorFactory(); 
    public IRefundCalculator CreateRefundCalculator() => new InternationalRefundCalculator(PaymentEntity);
    public ITaxCalculator CreateTaxCalculator() => new InternationalTaxCalculator(PaymentEntity);
}