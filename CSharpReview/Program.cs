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
            var name = "John Smith";
            // string is enumerable
            // just a list of chars

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // foreach is much cleaner and easier to read
            // string, array, list use a foreach
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
