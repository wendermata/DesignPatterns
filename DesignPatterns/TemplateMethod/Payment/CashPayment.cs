namespace DesignPatterns.TemplateMethod.Payment;

public class CashPayment : Payment
{
    public override decimal CalculateDiscount() => Value * 0.1m;
}