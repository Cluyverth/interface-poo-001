using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectE.Entities;

namespace ProjectE.Services
{
    internal class DeliveryServiceFactory
    {
        // Método para decidir qual serviço de entrega usar com base na localização do cliente
        public IDeliveryService GetDeliveryServiceByLocation(Client client)
        {
            // Se a localização do cliente for "Urban", usamos o PremiumDeliveryService, senão o normal
            if (client.Location == "Urban")
            {
                return new PremiumDeliveryService(); // Serviço premium
            }
            else
            {
                return new DeliveryService(); // Serviço normal
            }
        }
    }
}
