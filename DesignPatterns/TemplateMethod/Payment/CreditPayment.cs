namespace DesignPatterns.TemplateMethod.Payment;

public class CreditPayment : Payment
{
    public override decimal CalculateTax() => Value * 0.05m;
    public override decimal CalculateDiscount()
    {
        if (Value > 300)
            return Value * 0.02m;

        return 0;
    }
}