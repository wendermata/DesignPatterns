using DesignPatterns.Structural.Adapter.Gateway.EasyPay;
using DesignPatterns.Structural.Adapter.Gateway.TopPayment;

namespace DesignPatterns.Structural.Adapter;

public class AdapterPattern : IPattern
{
    public void Run()
    {
        var easyPayAdapter = new EasyPayAdapter();
        var topPaymentAdapter = new TopPaymentAdapter();
        
        var paymentProcessor = new PaymentProcessor(easyPayAdapter);
        paymentProcessor.SetChargeValue(100.00m);
        paymentProcessor.SetInstallments(3);
        paymentProcessor.SetCardNumber("1234-5678-9012-3456");
        paymentProcessor.SetCvv("123");
        if (paymentProcessor.ValidateCard())
        {
            var success = paymentProcessor.ProcessPayment();
            Console.WriteLine($"EasyPay Payment Success: {success}");
        }
        else
            Console.WriteLine("EasyPay Card Validation Failed");
        
        paymentProcessor.SetGateway(topPaymentAdapter);
        paymentProcessor.SetChargeValue(200.00m);
        paymentProcessor.SetInstallments(5);
        paymentProcessor.SetCardNumber("9876-5432-1098-7654");
        paymentProcessor.SetCvv("456");
        if (paymentProcessor.ValidateCard())
        {
            var success = paymentProcessor.ProcessPayment();
            Console.WriteLine($"TopPayment Payment Success: {success}");
        }
        else
            Console.WriteLine("TopPayment Card Validation Failed");
        
    }
}