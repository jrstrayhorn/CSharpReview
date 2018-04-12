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
            var numbers = new int[3]; // have to give a size
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // by default, values are set to default for that type
            // for int it's 0
            // for boolean it's false
            // for string it's null

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var titles = new string[3];
            titles[0] = "Con Air";

            Console.WriteLine(titles[0]);
            Console.WriteLine(titles[1]);
            Console.WriteLine(titles[2]);

            // object initialization syntax
            var names = new string[3] { "Jack", "John", "Mary" };

        }
    }
}
