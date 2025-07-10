namespace DesignPatterns.Structural.Adapter.Gateway;

public interface IGatewayAdapter
{
    void SetChargeValue(decimal value);
    void SetInstallments(int installments);
    void SetCardNumber(string cardNumber);
    void SetCvv(string cvv);
    bool ValidateCard();
    bool ProcessPayment();
}