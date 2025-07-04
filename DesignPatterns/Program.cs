using DesignPatterns.Strategy;
using DesignPatterns.TemplateMethod;
using DesignPatterns.Observer;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new ObserverPattern();
        pattern.Run();
        Console.ReadKey();
    }
}