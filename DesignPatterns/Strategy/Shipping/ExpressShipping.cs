namespace DesignPatterns.Strategy.Shipping;

public class ExpressShipping : IShippingMethod
{
    public decimal CalculateShippingCost(decimal orderValue) => orderValue * (decimal)0.1;
}