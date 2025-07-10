using DesignPatterns.Structural.Adapter.Gateway;

namespace DesignPatterns.Structural.Adapter;

public class PaymentProcessor
{
    public IGatewayAdapter GatewayAdapter { get; private set; }
    
    public PaymentProcessor(IGatewayAdapter gatewayAdapter)
    {
        GatewayAdapter = gatewayAdapter;
    }

    public void SetGateway(IGatewayAdapter gatewayAdapter) => GatewayAdapter = gatewayAdapter;
    public void SetChargeValue(decimal value) => GatewayAdapter.SetChargeValue(value);
    public void SetInstallments(int installments) => GatewayAdapter.SetInstallments(installments);
    public void SetCardNumber(string cardNumber) => GatewayAdapter.SetCardNumber(cardNumber);
    public void SetCvv(string cvv) => GatewayAdapter.SetCvv(cvv);
    public bool ValidateCard() => GatewayAdapter.ValidateCard();
    public bool ProcessPayment() => GatewayAdapter.ProcessPayment();

}