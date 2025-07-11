using DesignPatterns.Structural.Facade.Entity;

namespace DesignPatterns.Structural.Facade.Service.Repository;

public class OrderRepository
{
    private readonly List<OrderEntity> _orders = new();
    
    public void Save(OrderEntity entity)
    {
        _orders.Add(entity);
        Console.WriteLine($"Order saved: {entity}");
    }
    
    public OrderEntity GetById(string id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order == null)
        {
            Console.WriteLine($"Order with ID {id} not found.");
            throw new KeyNotFoundException($"Order with ID {id} not found.");
        }

        Console.WriteLine($"Order found: {order}");
        return order;
    }
}