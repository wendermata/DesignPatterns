namespace DesignPatterns.Strategy.Shipping;

public interface IShippingMethod
{
    decimal CalculateShippingCost(decimal orderValue);
}