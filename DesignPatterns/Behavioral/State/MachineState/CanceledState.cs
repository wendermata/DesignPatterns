namespace DesignPatterns.Behavioral.State.MachineState;

public class CanceledState() : IState
{
    public void CancelOrder() => 
        Console.WriteLine("Order is already canceled.");

    public void PayOrder() =>
        Console.WriteLine("Can´t pay an canceled order.");

    public void DispatchOrder() =>
        Console.WriteLine("Can´t dispatch an canceled order.");
}