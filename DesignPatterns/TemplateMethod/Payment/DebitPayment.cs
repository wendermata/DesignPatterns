namespace DesignPatterns.TemplateMethod.Payment;

public class DebitPayment : Payment
{
    public override decimal CalculateDiscount() => Value * 0.05m;
    public override decimal CalculateTax() => 4m;
}