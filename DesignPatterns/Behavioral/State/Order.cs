using DesignPatterns.Behavioral.State.MachineState;

namespace DesignPatterns.Behavioral.State;

public class Order
{
    public IState ActualState { get; private set; }

    public Order()
    {
        ActualState = new WaitingApprovalState(this);
    }
    
    public void SetState(IState state) => ActualState = state;
}