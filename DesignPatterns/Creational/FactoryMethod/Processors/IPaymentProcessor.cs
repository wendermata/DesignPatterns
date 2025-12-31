using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.FactoryMethod.Processors;

public interface IPaymentProcessor
{
    Task<bool> ProcessPayment(PaymentEntity payment);
}
