namespace DesignPatterns.Structural.Decorator.Coffee.Decorator;

public class ChantillyDecorator(ICoffee coffee) : ICoffee
{
    private ICoffee Coffee { get; } = coffee;

    public string GetDescription() => $"{Coffee.GetDescription()} + Chantilly";
    public decimal GetPrice() => Coffee.GetPrice() + (decimal)0.50;
}