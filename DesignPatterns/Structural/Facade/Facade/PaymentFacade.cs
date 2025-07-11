using DesignPatterns.Structural.Facade.Entity;
using DesignPatterns.Structural.Facade.Service.Cache;
using DesignPatterns.Structural.Facade.Service.Payment;
using DesignPatterns.Structural.Facade.Service.Repository;
using DesignPatterns.Structural.Facade.Service.Smtp;

namespace DesignPatterns.Structural.Facade.Facade;

public class PaymentFacade
{
    private readonly CacheService cacheService;
    private readonly OrderRepository orderRepository;
    private readonly PaymentService paymentService;
    private readonly SmtpService smtpService;

    public PaymentFacade()
    {
        cacheService = new CacheService();
        orderRepository = new OrderRepository();
        paymentService = new PaymentService();
        smtpService = new SmtpService();
    }
    
    public void ProcessPayment(OrderEntity order)
    {
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