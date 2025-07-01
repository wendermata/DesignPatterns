using DesignPatterns.Strategy.Shipping;

namespace DesignPatterns.Strategy.Order;

public class ElectronicOrder(decimal value, IShippingMethod shippingMethod) : Order (value, shippingMethod)
{
    public string SectorName { get; set; } = "Electronics";
}