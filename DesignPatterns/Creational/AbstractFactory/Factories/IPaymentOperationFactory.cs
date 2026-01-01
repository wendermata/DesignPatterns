using DesignPatterns.Creational.AbstractFactory.Refunds;
using DesignPatterns.Creational.AbstractFactory.Taxes;
using DesignPatterns.Creational.FactoryMethod.Factories;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public interface IPaymentOperationFactory
{
    PaymentProcessorFactory CreatePaymentProcessorFactory();
    IRefundCalculator CreateRefundCalculator();
    ITaxCalculator CreateTaxCalculator();
}