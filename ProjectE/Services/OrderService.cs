using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectE.Entities;

namespace ProjectE.Services
{
    internal class OrderService
    {
        private readonly IDeliveryService _deliveryService;

        // Injeção da interface no construtor
        public OrderService(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public void ProcessOrder(Order order)
        {
            // Usa o serviço de entrega para calcular a taxa
            order.DeliveryFee = _deliveryService.CalculateDeliveryFee(order);
        }
    }
}
