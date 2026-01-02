using DesignPatterns.Creational.Builder.Car;

namespace DesignPatterns.Creational.Builder;

public class BuilderPattern : IPattern
{
    public void Run()
    {
        var builder = new CarBuilder();

        var car = builder.WithId(Guid.NewGuid())
            .WithColor("Red")
            .WithMotor("Electric")
            .WithType(CarBodyType.Hatchback)
            .WithPassengersQuantity(5)
            .WithPrice(110000)
            .WithLeatherSeats()
            .Build();

        Console.WriteLine($"{car.Id} has been built with  {car.Color}" +
                          $" color and {car.Motor} motor and type {car.Type} and passengers limit {car.PassengersQuantity} " +
                          $" and bodytype {car.Type} with value {car.Price:C}.");
    }
}