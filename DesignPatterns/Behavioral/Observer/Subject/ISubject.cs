using DesignPatterns.Behavioral.Observer.Observers;

namespace DesignPatterns.Behavioral.Observer.Subject;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}