using DesignPatterns.Behavioral.State;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new FacadePattern();
        pattern.Run();
        Console.ReadKey();
    }
}