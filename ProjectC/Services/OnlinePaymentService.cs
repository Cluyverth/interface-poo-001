namespace ProjectC.Services
{
    internal class OnlinePaymentService : IOnlinePaymentService
    {
        public double CalculateInterest(double amount, int month)
        {
            return amount * 0.01 * month; // Juros simples de 1% por mês
        }

        public double CalculateFee(double amount)
        {
            return amount * 0.02; // Taxa fixa de 2%
        }
    }
}
