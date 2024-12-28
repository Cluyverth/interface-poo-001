using System.Globalization;
using ProjectD.Entities;
using ProjectD.Services;

Console.WriteLine("Enter Rental Data");
Console.WriteLine("Car Model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);

Console.WriteLine("Enter Price Per Hour: ");
double  hours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Enter Price Per Day: ");
double days = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(startDate, endDate, new Vehicle(model));

RentalService rentalService = new RentalService(hours, days, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);
Console.WriteLine("Invoice: ");
Console.WriteLine(carRental.Invoice);