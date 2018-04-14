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
            var numbers = new [] { 3, 7, 9, 2, 14, 6 };

            // length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf() - find index of element of array
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            // Clear - sets items to default
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(another);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


        }
    }
}
