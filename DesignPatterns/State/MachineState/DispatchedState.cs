namespace DesignPatterns.State.MachineState;

public class DispatchedState : IState
{
    public void CancelOrder() =>
        Console.WriteLine("Can´t cancel an order that has been dispatched.");

    public void PayOrder() =>
        Console.WriteLine("Can´t pay an order that has been dispatched.");

    public void DispatchOrder() =>
        Console.WriteLine("Can´t dispatch an order that has been dispatched.");
}