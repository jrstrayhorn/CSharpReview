using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{

    // where T : IComparable (on an interface)
    // where T : Product (or any of Product's subclasses)
    // where T : struct (value type)
    // where T : class (reference type)
    // where T : new() (where class has a default constructor)

    // we are saying that T has to implement IComparable interface
    // allows us to put some constraints on which T can be used
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // use this method signature if you only want it
        // on the method in a non generic class or see above
        // to make class generic
        //public T Max<T>(T a, T b) where T : IComparable
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
