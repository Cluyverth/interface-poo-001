using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectE.Entities;

namespace ProjectE.Services
{
    internal class PremiumDeliveryService : IDeliveryService
    {
        public double CalculateDeliveryFee(Order order)
        {
            // Taxa de entrega premium: 5% do valor do pedido
            return order.Amount * 0.05;
        }
    }
}
