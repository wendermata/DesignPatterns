namespace DesignPatterns.Behavioral.Strategy.Shipping;

public interface IShippingMethod
{
    decimal CalculateShippingCost(decimal orderValue);
}