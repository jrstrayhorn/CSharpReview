using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // HERE: new is glue, we've created a tightly coupling
            // between this OrderProcessor class and ShippingCalculator class
            //_shippingCalculator = new ShippingCalculator();

            // now no reference to concrete ShippingCalculator
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            // defensive programming - make sure you don't have valid state
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
