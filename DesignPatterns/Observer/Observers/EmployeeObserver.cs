namespace DesignPatterns.Observer.Observers;

public class EmployeeObserver (string name, string email) : IObserver
{
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;


    public void Update(string message) => Console.WriteLine($"Observer:{Name}. Email: {Email}. Message received: {message}");
}