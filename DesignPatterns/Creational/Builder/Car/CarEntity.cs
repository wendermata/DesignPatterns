namespace DesignPatterns.Creational.Builder.Car;

public class CarEntity
{
    public Guid Id { get; set; }
    public string Color { get; set; }
    public string Motor { get; set; }
    public CarBodyType Type { get; set; }
    public int PassengersQuantity { get; set; }
    public bool IsLeatherSeats { get; set; }
    public decimal Price  { get; set; }
}