using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.AbstractFactory.Taxes;

public class InternationalTaxCalculator(PaymentEntity paymentEntity) : ITaxCalculator
{
    private PaymentEntity PaymentEntity { get; set; } = paymentEntity;

    public Task GetTax()
    {
        if (PaymentEntity.Value >= 200)
        {
            PaymentEntity.TaxValue = PaymentEntity.Value * (decimal)0.1;
            Console.WriteLine("Tax Value: " + PaymentEntity.TaxValue);
            return Task.CompletedTask;
        }
        PaymentEntity.TaxValue = PaymentEntity.Value * (decimal)0.05;
        Console.WriteLine("Tax Value: " + PaymentEntity.TaxValue);
        return Task.CompletedTask;
    }
}