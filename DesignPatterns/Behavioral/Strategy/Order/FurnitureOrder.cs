using DesignPatterns.Behavioral.Strategy.Shipping;

namespace DesignPatterns.Behavioral.Strategy.Order;

public class FurnitureOrder(decimal value, IShippingMethod shippingMethod) : Order (value, shippingMethod)
{
    public string SectorName { get; set; } = "Furniture";
}