namespace DesignPatterns.State.MachineState;

public class PaidState (Order context) : IState
{
    public Order Context { get; set; } = context;

    public void CancelOrder()
    {
        Context.SetState(new CanceledState());
        Console.WriteLine("Order has been canceled.");
    }

    public void PayOrder() =>
        Console.WriteLine("Order has already been paid.");

    public void DispatchOrder()
    {
        Context.SetState(new DispatchedState());
        Console.WriteLine("Order has been dispatched successfully.");
    }
}