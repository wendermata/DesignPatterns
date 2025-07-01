using DesignPatterns.Strategy.Order;
using DesignPatterns.Strategy.Shipping;

namespace DesignPatterns.Strategy;

public class StrategyPattern : IPattern
{
    public void Run()
    {
        var commonShipping = new CommonShipping();
        var expressShipping = new ExpressShipping();
        
        var electronicOrder = new ElectronicOrder(100, commonShipping);
        Console.WriteLine(electronicOrder.SectorName + $" | {electronicOrder.ShippingMethod.GetType().Name}" +" | Order Shipping Cost: " + electronicOrder.CalculateShippingCost());
        
        electronicOrder.SetShippingMethod(expressShipping);
        Console.WriteLine(electronicOrder.SectorName + $" | {electronicOrder.ShippingMethod.GetType().Name}" +" | Order Shipping Cost: " + electronicOrder.CalculateShippingCost());
     
        var furnitureOrder = new FurnitureOrder(200, commonShipping);
        Console.WriteLine(furnitureOrder.SectorName + $" | {furnitureOrder.ShippingMethod.GetType().Name}" +" | Order Shipping Cost: " + furnitureOrder.CalculateShippingCost());
    }
}