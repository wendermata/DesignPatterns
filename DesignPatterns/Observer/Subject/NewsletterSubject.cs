using DesignPatterns.Observer.Observers;

namespace DesignPatterns.Observer.Subject;

public class NewsletterSubject : ISubject
{
    public List<IObserver> Observers { get; private set; } = [];
    public List<string> Messages { get; private set; } = [];
    
    
    public void AddMessage(string message)
    {
        Messages.Add(message);
        NotifyObservers();
    }
    
    public void RegisterObserver(IObserver observer) => Observers.Add(observer);

    public void RemoveObserver(IObserver observer) => Observers.Remove(observer);

    public void NotifyObservers()
    {
        var message = Messages.LastOrDefault();
        foreach (var observer in Observers)
            observer.Update(message);
    }
}