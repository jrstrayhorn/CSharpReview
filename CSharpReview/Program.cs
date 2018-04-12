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
            // arimetic operators
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);

            Console.WriteLine((float)a + (float)b);

            var c = 4;

            Console.WriteLine((a + b) * c);

            // comparision
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b)); // sames as a ==b

            // logical
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));


        }
    }
}
