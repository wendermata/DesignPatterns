using DesignPatterns.Strategy.Shipping;

namespace DesignPatterns.Strategy.Order;

public class FurnitureOrder(decimal value, IShippingMethod shippingMethod) : Order (value, shippingMethod)
{
    public string SectorName { get; set; } = "Furniture";
}