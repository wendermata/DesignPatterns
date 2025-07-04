using DesignPatterns.Strategy;
using DesignPatterns.TemplateMethod;
using DesignPatterns.Observer;
using DesignPatterns.State;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new StatePattern();
        pattern.Run();
        Console.ReadKey();
    }
}