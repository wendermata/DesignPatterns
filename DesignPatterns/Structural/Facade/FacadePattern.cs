using DesignPatterns.Structural.Facade.Entity;
using DesignPatterns.Structural.Facade.Facade;

namespace DesignPatterns.Structural.Facade;

public class FacadePattern : IPattern
{
    private readonly PaymentFacade _paymentFacade = new();

    public void Run()
    {
        Console.WriteLine("Creating Order Entity...");
        var order = new OrderEntity("123", "John Doe", "Laptop", 1200.00m);
        Console.WriteLine(order);
     
        Console.WriteLine("Processing Payment through Facade...");
        _paymentFacade.ProcessPayment(order);
    }
}