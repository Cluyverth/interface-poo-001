using System.Globalization;

Console.WriteLine("Enter contract data");
Console.WriteLine("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Date (dd/MM/yyyy): ");
DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine("Contract Value: ");
double contractValue = double.Parse(Console.ReadLine());
Console.WriteLine("Enter The Number of Installments: ");
int contractInstallmentsNumber = int.Parse(Console.ReadLine());

