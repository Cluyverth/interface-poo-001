namespace ProjectC.Services
{
    internal interface IOnlinePaymentService
    {
        double CalculateInterest(double amount, int month);
        double CalculateFee(double amount);
    }
}
