namespace DesignPatterns.Structural.Decorator.Coffee;

public class TraditionalCoffee : ICoffee
{
    
    public string GetDescription() => "Traditional Coffee";

    public decimal GetPrice() => (decimal)2.50;
  
}