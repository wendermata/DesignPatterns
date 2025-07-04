namespace DesignPatterns.State.MachineState;

public interface IState
{
    void CancelOrder();
    void PayOrder();
    void DispatchOrder();
}