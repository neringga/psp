namespace StrategyPattern
{
    public interface IPaymentStrategy
    {
        void ShowMonthlySalary(int month);
        void ShowAnnualSalary();
        void ShowBonus();
    }
}
