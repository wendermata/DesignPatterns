using DesignPatterns.Behavioral.Strategy.Shipping;

namespace DesignPatterns.Behavioral.Strategy.Order;

public abstract class Order
{
    public decimal Value { get; private set; }
    public IShippingMethod ShippingMethod { get; private set; }
    
    public Order(decimal value, IShippingMethod shippingMethod)
    {
        Value = value;
        ShippingMethod = shippingMethod;
    }

    public string CalculateShippingCost() => ShippingMethod.CalculateShippingCost(Value).ToString("C");
    
    public void SetShippingMethod(IShippingMethod shippingMethod) => ShippingMethod = shippingMethod;

}