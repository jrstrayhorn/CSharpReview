using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // only show this public interface
        public void Promote()
        {
            // how this works should be hidden
            var calculator = new RateCalculator();  // not a good practice, as we create coupling
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");
        }

        // this is an implementation detail shouldn't show the rest of the world
        // if we make protected then this detail would leak into other subclasses
        // try to avoid protected unless you absolutely need it
        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
