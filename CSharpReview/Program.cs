using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    // automatically set to 0 if not setting values
    // but you should set esp if enum in database
    // IDs should match enum value
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            // INTERNALLY an enum is an integer
            Console.WriteLine((int)method);

            // might get a number from system and need to convert to
            // enum
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // need to convert enum to string or vice versa
            Console.WriteLine(method.ToString());

            // console writeline always calls tostring.. so you don't need it
            Console.WriteLine(method);

            // can also use nameof()
            Console.WriteLine($"Enum is {nameof(ShippingMethod.Express)}");
            var methodName = "Express";

            // parse string to a different type
            // Enum class can help to parse
            // type class is a class with metadata about type
            // when you see Type always use typeof
            // need to cast this bc Enum.Parse returns object
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);  
        }
    }
}
