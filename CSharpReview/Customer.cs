using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Customer
    {
        // real world no public fields
        public int Id;
        public string Name;

        // if list of objects in class
        // always initialize new list
        // in constructor
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // this will call the parameterless constructor
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // this will call the constructor with id as parameter
        {
            this.Name = name;
        }

        // use this() only when needed
        // only use constructor only when you really need
        // to set initial state on an object
    }
}
