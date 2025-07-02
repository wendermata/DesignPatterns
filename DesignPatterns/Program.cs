using DesignPatterns.Strategy;
using DesignPatterns.TemplateMethod;

namespace DesignPatterns;

public class Program
{
    static void Main(string[] args)
    {
        var pattern = new TemplateMethodPattern();
        pattern.Run();
        Console.ReadKey();
    }
}