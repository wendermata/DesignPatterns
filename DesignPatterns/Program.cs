using DesignPatterns.Behavioral.State;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new AdapterPattern();
        pattern.Run();
        Console.ReadKey();
    }
}