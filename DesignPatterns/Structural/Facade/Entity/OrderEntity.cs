namespace DesignPatterns.Structural.Facade.Entity;

public class OrderEntity(string id, 
    string client,
    string product,
    decimal price)
{
    public string Id { get; private set; } = id;
    public string Client { get; private set; } = client;
    public string Product { get; private set; } = product;
    public decimal Price { get; private set; } = price;
    
    public override string ToString()
    {
        return $"Order: {Id}, Client: {Client}, Product: {Product}, Price: {Price:C}";
    }
}