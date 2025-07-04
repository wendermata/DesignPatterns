using DesignPatterns.Observer.Observers;
using DesignPatterns.Observer.Subject;

namespace DesignPatterns.Observer;

public class ObserverPattern : IPattern
{
    public void Run()
    {
        var subject = new NewsletterSubject();
        
        var observer1 = new ClientObserver("Client", "client@client.com");
        var observer2 = new EmployeeObserver("Employee", "employee@employee.com");
        var observer3 = new PartnerObserver("Partner", "partner@partner.com");
        
        subject.RegisterObserver(observer1);
        subject.RegisterObserver(observer2);
        subject.RegisterObserver(observer3);
        
        subject.AddMessage("Welcome to our newsletter!");
        
        subject.RemoveObserver(observer2);
        
        subject.AddMessage("New product launch next week!");
    }
}