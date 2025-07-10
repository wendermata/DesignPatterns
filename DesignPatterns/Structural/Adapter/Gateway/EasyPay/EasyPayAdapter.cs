namespace DesignPatterns.Structural.Adapter.Gateway.EasyPay;

public class EasyPayAdapter : IGatewayAdapter
{
    public EasyPayGateway Gateway { get; }

    public EasyPayAdapter()
    {
        Gateway = new EasyPayGateway();
    }
    
    public void SetChargeValue(decimal value) => Gateway.SetChargeValue(value);
    public void SetInstallments(int installments) => Gateway.SetInstallments(installments);
    public void SetCardNumber(string cardNumber) => Gateway.SetCardNumber(cardNumber);
    public void SetCvv(string cvv) => Gateway.SetCvv(cvv);
    public bool ValidateCard() => Gateway.ValidateCard();
    public bool ProcessPayment() => Gateway.ProcessPayment();
}