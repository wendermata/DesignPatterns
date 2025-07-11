namespace DesignPatterns.Structural.Facade.Service.Payment;

public class PaymentService
{
    public void ProcessPayment(string client, string product, decimal price)
    {
        Console.WriteLine($"Processing payment for {client} for product {product} with price {price:C}");
        Console.WriteLine("Payment processed successfully.");
    }
    
}