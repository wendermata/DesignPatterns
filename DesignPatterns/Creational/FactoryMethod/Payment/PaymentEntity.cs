namespace DesignPatterns.Creational.FactoryMethod.Payment;

public class PaymentEntity
{
    public PaymentType Type { get; set; }
    public decimal Value { get; set; }
    public bool IsProcessed { get; set; }
}