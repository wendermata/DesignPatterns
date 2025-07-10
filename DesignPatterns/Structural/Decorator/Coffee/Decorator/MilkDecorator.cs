namespace DesignPatterns.Structural.Decorator.Coffee.Decorator;

public class MilkDecorator(ICoffee coffee) : ICoffee
{
    private ICoffee Coffee { get; } = coffee;

    public string GetDescription() => $"{Coffee.GetDescription()} + Milk";
    public decimal GetPrice() => Coffee.GetPrice() + (decimal)1.50;
}