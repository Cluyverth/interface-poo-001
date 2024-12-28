using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectE.Entities
{
    internal class Order
    {
        public int OrderNumber { get; }
        public Client Client { get; }
        public double Amount { get; }
        public double DeliveryFee { get; set; }

        public Order(int orderNumber, Client client, double amount)
        {
            OrderNumber = orderNumber;
            Client = client;
            Amount = amount;
        }
    }
}
