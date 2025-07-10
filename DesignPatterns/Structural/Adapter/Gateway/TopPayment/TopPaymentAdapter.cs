namespace DesignPatterns.Structural.Adapter.Gateway.TopPayment;

public class TopPaymentAdapter : IGatewayAdapter
{
    public TopPaymentGateway Gateway { get; }
    public string CardNumber { get; private set; }
    public string Cvv { get; private set; }

    public TopPaymentAdapter()
    {
        Gateway = new TopPaymentGateway();
    }
    
    public void SetChargeValue(decimal value) => Gateway.SetChargeTotal(value);
    public void SetInstallments(int installments) => Gateway.SetInstallmentQuantity(installments);
    public void SetCardNumber(string cardNumber)
    {
        CardNumber = cardNumber;
        
        if(!string.IsNullOrWhiteSpace(Cvv))
            Gateway.SetCreditCard(cardNumber, Cvv);
    }

    public void SetCvv(string cvv)
    {
        Cvv = cvv;
        
        if(!string.IsNullOrWhiteSpace(CardNumber))
            Gateway.SetCreditCard(CardNumber, Cvv);
    }

    public bool ValidateCard()
    {
        Console.WriteLine($"Card Number: {CardNumber} only will be validated after process payment.");
        return false;
    }

    public bool ProcessPayment() => Gateway.ProcessPayment();
}