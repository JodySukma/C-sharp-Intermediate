using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selection_6.InterfaceAndTestbility;

namespace Selection_6_TestBility
{
    [TestClass]
    public class OrderProsessorTest
    {
        // Method_Condition_Exeptation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAndExeption()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcess = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcess.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
