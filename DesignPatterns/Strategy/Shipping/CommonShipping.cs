namespace DesignPatterns.Strategy.Shipping;

public class CommonShipping : IShippingMethod
{
    public decimal CalculateShippingCost(decimal orderValue) => orderValue * (decimal)0.05;
}