namespace DesignPatterns.Behavioral.State;

public class StatePattern : IPattern
{
    public void Run()
    {
        var order = new Order();
        
        //invalid operation
        order.ActualState.DispatchOrder();
        
        //valid operation
        order.ActualState.PayOrder();
        order.ActualState.CancelOrder();
        
        //invalid operation
        order.ActualState.DispatchOrder();
        
    }
}