using DesignPatterns.Creational.FactoryMethod.Payment;

namespace DesignPatterns.Creational.AbstractFactory.Refunds;

public class BrazilianRefundCalculator(PaymentEntity paymentEntity) : IRefundCalculator
{
    public PaymentEntity PaymentEntity { get; set; } = paymentEntity;

    public async Task<bool> IsEligibleToRefund()
    {
        if (PaymentEntity.TaxValue > 2000)
            return true;

        return false;
    }

    public Task GetRefund()
    {
        PaymentEntity.RefundValue = PaymentEntity.TaxValue * (decimal)0.20;
        return Task.CompletedTask;
    }
}