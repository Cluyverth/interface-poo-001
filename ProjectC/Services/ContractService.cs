using ProjectC.Entities;

namespace ProjectC.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _paymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicInstallment = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updatedAmount = basicInstallment + _paymentService.CalculateInterest(basicInstallment, i);
                double fullAmount = updatedAmount + _paymentService.CalculateFee(updatedAmount);

                contract.AddInstallment(new Installment(dueDate, fullAmount));
            }
        }
    }
}
