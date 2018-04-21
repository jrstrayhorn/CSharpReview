using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Customer
    {
        public int Id;
        public string Name;

        // if you have a list should always
        // initialize to an empty list
        public readonly List<Order> Orders = new List<Order>(); // this will only be set once!!!

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // .....
        }

    }
}
