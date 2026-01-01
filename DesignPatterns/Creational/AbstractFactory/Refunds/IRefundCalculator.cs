namespace DesignPatterns.Creational.AbstractFactory.Refunds;

public interface IRefundCalculator
{
    Task<bool> IsEligibleToRefund();
    Task GetRefund();    
}