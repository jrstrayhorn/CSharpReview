using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calc = new RateCalculator();  // we just created a dependency
            // if we removed RAteCalculator class, program would break
            // but if we make it internal it would only be visible from Amazon 
        }
    }
}
