using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectE.Entities;

namespace ProjectE.Services
{
    internal interface IDeliveryService
    {
        double CalculateDeliveryFee(Order order);
    }
}
