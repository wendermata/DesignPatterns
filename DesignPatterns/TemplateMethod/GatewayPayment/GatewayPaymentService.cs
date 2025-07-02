namespace DesignPatterns.TemplateMethod.GatewayPayment;

public class GatewayPaymentService
{
    public bool ProcessPayment(decimal amount)
    {
        if (amount <= 0)
        {
          Console.WriteLine("Amount must be greater than zero");
          return false;
        }

        Console.WriteLine($"Processing payment of {amount:C}");
        Console.WriteLine($"Payment processed successfully.");
        return true;
    }
}