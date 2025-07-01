using DesignPatterns.Strategy;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new StrategyPattern();
        pattern.Run();
        Console.ReadKey();
    }
}