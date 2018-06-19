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
            object obj = "JR";
            //obj.GetHashCode()

            // reflection - other one is better
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            dynamic excelObject = "jr";
            excelObject.Optimize(); // dynamic allows us to call methods that wont pass compile time checking
                                    // we are telling the compiler to trust us that there is a method or prop there at run time just
                                    // not at compile time

            // CLR takes IL and converts to machine code
            // DLR in .NET 4 sits on top of CLR and gives dynamic capabilities

            dynamic name = "JR";
            name = 10;  // bc dyanmic we can set to any type we want
                        // changes type at run time

            name++; // you can do this but it will break at runtime
                    // operator can't be applie to type string

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;  // c will be dynamic

            int i = 5;
            dynamic d = i;  // at run time d will be an int
            long l = d; // at run time d will be int and will implicitly cast to long
        }
    }
}
