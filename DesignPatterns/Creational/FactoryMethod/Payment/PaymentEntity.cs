namespace DesignPatterns.Creational.FactoryMethod.Payment;

public class PaymentEntity
{
    public PaymentType Type { get; set; }
    public decimal Value { get; set; }
    public decimal TaxValue { get; set; }
    public decimal RefundValue { get; set; }
    public bool IsProcessed { get; set; }
}