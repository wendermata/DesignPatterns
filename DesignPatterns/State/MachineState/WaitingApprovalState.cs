namespace DesignPatterns.State.MachineState;

public class WaitingApprovalState(Order context) : IState
{
    public Order Context { get; set; } = context;

    public void CancelOrder() 
    {
        Context.SetState(new CanceledState());
        Console.WriteLine("Order has been canceled.");
    }

    public void PayOrder()=>
        Console.WriteLine("Order has been paid successfully.");

    public void DispatchOrder() =>
        Console.WriteLine("Cannot dispatch order, it is still waiting for approval.");
    
}