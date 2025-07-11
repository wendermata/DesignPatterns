using DesignPatterns.Structural.Facade.Entity;
using DesignPatterns.Structural.Facade.Service.Cache;
using DesignPatterns.Structural.Facade.Service.Payment;
using DesignPatterns.Structural.Facade.Service.Repository;
using DesignPatterns.Structural.Facade.Service.Smtp;

namespace DesignPatterns.Structural.Facade;

public class ClientWithoutFacade : IPattern
{
    public void Run()
    {
        var cacheService = new CacheService();
        var orderRepository = new OrderRepository();
        var paymentService = new PaymentService();
        var smtpService = new SmtpService();
        
        Console.WriteLine("Creating Order Entity...");
        var order = new OrderEntity("123", "John Doe", "Laptop", 1200.00m);
        Console.WriteLine(order);
        
        Console.WriteLine("Saving Order to Repository...");
        orderRepository.Save(order);
        
        Console.WriteLine("Caching Order Data...");
        cacheService.CacheData(order.Id, order);
        
        Console.WriteLine("Processing Payment...");
        paymentService.ProcessPayment(order.Client, order.Product, order.Price);
        
        Console.WriteLine("Sending Confirmation Email...");
        if (!smtpService.SendEmail(order.Client)!)
            Console.WriteLine("Failed to send confirmation email.");
    }
}