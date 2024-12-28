using System.Globalization;
using ProjectC.Services;
using ProjectC.Entities;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract Value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter the number of installments: ");
int installmentsNumber = int.Parse(Console.ReadLine());

Contract contract = new Contract(contractNumber, contractDate, contractValue);
ContractService contractService = new ContractService(new OnlinePaymentService());

contractService.ProcessContract(contract, installmentsNumber);

Console.WriteLine("Installments:");
foreach (var installment in contract.Installments)
{
    Console.WriteLine(installment);
}

