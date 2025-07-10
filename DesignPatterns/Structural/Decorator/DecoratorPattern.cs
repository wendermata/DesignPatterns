using DesignPatterns.Structural.Decorator.Coffee;
using DesignPatterns.Structural.Decorator.Coffee.Decorator;

namespace DesignPatterns.Structural.Decorator;

public class DecoratorPattern : IPattern
{
    public void Run()
    {
        var traditionalCoffee = new TraditionalCoffee();
        Console.WriteLine($"{traditionalCoffee.GetDescription()} - {traditionalCoffee.GetPrice():C}");
        var milkDecorator = new MilkDecorator(traditionalCoffee);
        Console.WriteLine($"{milkDecorator.GetDescription()} - {milkDecorator.GetPrice():C}");
        
        var espressoCoffee = new EspressoCoffee();
        Console.WriteLine($"{espressoCoffee.GetDescription()} - {espressoCoffee.GetPrice():C}");
        var chantillyDecorator = new ChantillyDecorator(espressoCoffee);
        Console.WriteLine($"{chantillyDecorator.GetDescription()} - {chantillyDecorator.GetPrice():C}");
        milkDecorator = new MilkDecorator(chantillyDecorator);
        Console.WriteLine($"{milkDecorator.GetDescription()} - {milkDecorator.GetPrice():C}");
    }
}