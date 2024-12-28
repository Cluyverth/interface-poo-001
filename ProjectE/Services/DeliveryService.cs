using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectE.Entities;

namespace ProjectE.Services
{
    internal class DeliveryService : IDeliveryService
    {
        public double CalculateDeliveryFee(Order order)
        {
            // Taxa de entrega normal: 10% do valor do pedido
            return order.Amount * 0.1;
        }
    }
}
