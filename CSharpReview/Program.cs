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
            // generic lists
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1); // arrays don't have add, arrays you can't change size later

            // IEnumerable is an interface, if you see IEnumerable you can use
            // array or list
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");

            Console.WriteLine($"Index of 1: {numbers.LastIndexOf(1)}");

            Console.WriteLine("Count: " + numbers.Count);



            //foreach (var number in numbers)
            //{
            //    if (number == 1)    
            //        numbers.Remove(number); // this will cause an exception bc collection is modified during loop
            //}


            // this will work!!
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
