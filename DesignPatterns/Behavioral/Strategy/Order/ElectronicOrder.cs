using DesignPatterns.Behavioral.Strategy.Shipping;

namespace DesignPatterns.Behavioral.Strategy.Order;

public class ElectronicOrder(decimal value, IShippingMethod shippingMethod) : Order (value, shippingMethod)
{
    public string SectorName { get; set; } = "Electronics";
}