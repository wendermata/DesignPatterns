using DesignPatterns.Behavioral.TemplateMethod.GatewayPayment;
using DesignPatterns.Behavioral.TemplateMethod.Payment;

namespace DesignPatterns.Behavioral.TemplateMethod;

public class TemplateMethodPattern : IPattern
{
    public void Run()
    {
        var gatewayPaymentService = new GatewayPaymentService();
        
        var cashPayment = new CashPayment
        {
            Value = 1000,
            GatewayPayment = gatewayPaymentService
        };
        
        var debitPayment = new DebitPayment
        {
            Value = 1000,
            GatewayPayment = gatewayPaymentService
        };
        
        var creditPayment = new CreditPayment
        {
            Value = 1000,
            GatewayPayment = gatewayPaymentService
        };

        cashPayment.ProcessPayment();
        debitPayment.ProcessPayment();
        creditPayment.ProcessPayment();
    }
}