using DesignPatterns.Behavioral.TemplateMethod.GatewayPayment;

namespace DesignPatterns.Behavioral.TemplateMethod.Payment;

public abstract class Payment
{
    public decimal Value { get; set; }
    public GatewayPaymentService GatewayPayment { get; set; }

    public virtual decimal CalculateTax()
    {
        Console.WriteLine("Calculating default tax for payment.");
        return 0;
    }

    public abstract decimal CalculateDiscount();

    public bool ProcessPayment()
    {
        var tax = CalculateTax();
        var discount = CalculateDiscount();

        var finalValue = Value + tax - discount;
        Console.WriteLine($"{Value.ToString("C")} + {tax.ToString("C")} - {discount.ToString("C")} = + {finalValue.ToString("C")}");
        Console.WriteLine("Processing payment with final value: " + finalValue.ToString("C"));
        return GatewayPayment.ProcessPayment(finalValue);
    }
}