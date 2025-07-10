using DesignPatterns.Behavioral.State;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Decorator;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new DecoratorPattern();
        pattern.Run();
        Console.ReadKey();
    }
}