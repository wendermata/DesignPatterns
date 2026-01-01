using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.AbstractFactory;

public class AbstractFactoryPattern : IPattern
{
    private readonly PaymentEntity _creditPayment = new()
    {
        Value = 1000000,
        Type = PaymentType.CreditCard,
        IsProcessed = false
    };

    private readonly PaymentEntity _debitPayment = new()
    {
        Value = 20000,
        Type = PaymentType.DebitCard,
        IsProcessed = false
    };

    private readonly PaymentEntity _pixPayment = new()
    {
        Value = 3000,
        Type = PaymentType.Pix,
        IsProcessed = false
    };

    public void Run()
    {
        //mixing abstract + factory method

        IPaymentOperationFactory factory = new BrazilianOperationFactory(_creditPayment);
        var taxCalculator = factory.CreateTaxCalculator(); //return brazilian tax
        var refundCalculator = factory.CreateRefundCalculator(); //return brazilian refund
        var paymentProcessor = factory.CreatePaymentProcessorFactory(); //return brazilian payment processor

        paymentProcessor.ProcessAsync(_creditPayment).ConfigureAwait(true);
        taxCalculator.GetTax();
        
        if (refundCalculator.IsEligibleToRefund().Result)
            refundCalculator.GetRefund();
        
        factory = new InternationalOperationFactory(_pixPayment);
        taxCalculator = factory.CreateTaxCalculator();
        paymentProcessor = factory.CreatePaymentProcessorFactory();
        refundCalculator = factory.CreateRefundCalculator();
        
        //operation doesnt support pix, so error will be thrown
        paymentProcessor.ProcessAsync(_pixPayment).ConfigureAwait(true);
        taxCalculator.GetTax();
        
        if (refundCalculator.IsEligibleToRefund().Result)
            refundCalculator.GetRefund();
    }
}