using DesignPatterns.Creational.Builder.Car;

namespace DesignPatterns.Creational.Builder;

public class CarBuilder
{
    private Guid _id;
    private string _color;
    private string _motor;
    private CarBodyType _type;
    private int _passengersQuantity;
    private bool _isLeatherSeat;
    private decimal _price;
    
    public CarBuilder WithId(Guid id)
    {
        _id = id;
        return this;
    }

    public CarBuilder WithColor(string color)
    {
        _color = color;
        return this;
    }

    public CarBuilder WithMotor(string motor)
    {
        _motor = motor;
        return this;
    }

    public CarBuilder WithType(CarBodyType type)
    {
        _type = type;
        return this;
    }

    public CarBuilder WithPassengersQuantity(int quantity)
    {
        _passengersQuantity = quantity;
        return this;
    }

    public CarBuilder WithLeatherSeats()
    {
        _isLeatherSeat = true;
        return this;
    }

    public CarBuilder WithPrice(decimal price)
    {
        _price = price;
        return this;
    }

    public CarEntity Build() => new()
    {
        Id = _id,
        Color = _color,
        Motor = _motor,
        Type = _type,
        IsLeatherSeats = _isLeatherSeat,
        PassengersQuantity = _passengersQuantity,
        Price = _price
    };
}