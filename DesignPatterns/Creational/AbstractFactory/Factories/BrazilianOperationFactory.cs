using DesignPatterns.Creational.AbstractFactory.Refunds;
using DesignPatterns.Creational.AbstractFactory.Taxes;
using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class BrazilianOperationFactory (PaymentEntity paymentEntity) : IPaymentOperationFactory
{
    private PaymentEntity PaymentEntity { get; set; } = paymentEntity;

    public PaymentProcessorFactory CreatePaymentProcessorFactory() => new BrazilianPaymentProcessorFactory(); 
    public IRefundCalculator CreateRefundCalculator() => new BrazilianRefundCalculator(PaymentEntity);
    public ITaxCalculator CreateTaxCalculator() => new BrazilianTaxCalculator(PaymentEntity);
}