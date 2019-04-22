using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6.InterfaceAndTestbilityExam
{

    public class OrderProsessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProsessor()
        {
            _shippingCalculator = _shippingCalculator();
        }

        public void Processor(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationExeption("This order is already processed");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1);
            };
        }
    }
}
