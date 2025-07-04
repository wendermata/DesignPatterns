using DesignPatterns.Observer.Observers;

namespace DesignPatterns.Observer.Subject;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}