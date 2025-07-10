namespace DesignPatterns.Structural.Adapter.Gateway.EasyPay;

public class EasyPayGateway
{
    public decimal ChargeValue { get; private set; }
    public int Installments { get; private set; }
    public string CardNumber { get; private set; }
    public string Cvv { get; private set; }
    
    
    public void SetChargeValue(decimal value)
    {
        Console.WriteLine($"{nameof(EasyPayGateway)}: Setting Charge Value with value: " + value);
        ChargeValue = value;
    }

    public void SetInstallments(int installments)
    {
        Console.WriteLine($"{nameof(EasyPayGateway)}: Setting Installments with quantity: " + installments);
        Installments = installments;
    }

    public void SetCardNumber(string cardNumber)
    {
        Console.WriteLine($"{nameof(EasyPayGateway)}: Setting Card Number with number: " + cardNumber);
        CardNumber = cardNumber;
    }

    public void SetCvv(string cvv)
    {
        Console.WriteLine($"{nameof(EasyPayGateway)}: Setting Card CVV with number: " + cvv);
        Cvv = cvv;
    }

    public bool ValidateCard()
    {
        Console.WriteLine($"{nameof(EasyPayGateway)}: Validating card");
        return new Random().Next(2) == 0;;
    }

    public bool ProcessPayment()
    {
        Console.WriteLine($"{nameof(EasyPayGateway)}: Processing payment with charge value: {ChargeValue}, installments: {Installments}, card number: {CardNumber}, cvv: {Cvv}");
        return new Random().Next(2) == 0;;
    }
}