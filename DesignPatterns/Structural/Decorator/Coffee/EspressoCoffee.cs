namespace DesignPatterns.Structural.Decorator.Coffee;

public class EspressoCoffee : ICoffee
{

    public string GetDescription() => "Espresso Coffee";

    public decimal GetPrice() => (decimal)5.00;
}