namespace DesignPatterns.Structural.Adapter.Gateway.TopPayment;

public class TopPaymentGateway
{
    public decimal ChargeTotal { get; private set; }
    public int InstallmentQuantity { get; private set; }
    public string CardNumber { get; private set; }
    public string Cvv { get; private set; }
    
    
    public void SetChargeTotal(decimal value)
    {
        Console.WriteLine($"{nameof(TopPaymentGateway)}: Setting charge value with value: " + value);
        ChargeTotal = value;
    }

    public void SetInstallmentQuantity(int count)
    {
        Console.WriteLine($"{nameof(TopPaymentGateway)}: Setting installments with quantity: " + count);
        InstallmentQuantity = count;
    }

    public void SetCreditCard(string cardNumber, string cvv)
    {
        Console.WriteLine($"{nameof(TopPaymentGateway)}: Setting Card with Number: " + cardNumber + " and CVV: " + cvv);
        CardNumber = cardNumber;
        Cvv = cvv;
    }

    public bool ProcessPayment()
    {
        Console.WriteLine($"{nameof(TopPaymentGateway)}: Processing payment with charge value: {ChargeTotal}, installments: {InstallmentQuantity}, card number: {CardNumber}, cvv: {Cvv}");
        return true;
    }
}