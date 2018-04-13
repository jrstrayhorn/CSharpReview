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
            var a = 10;
            var b = a;
            b++;

            // ? what is value of a at this point
            // answer is 10 bc int is value type
            // a copy of value is stored in target location
            // value type means value is copied

            Console.WriteLine($"a: {a}, b: {b}");

            // array is a class so reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            // ? what is 1st element of array 1
            // answer is 0
            // why? b/c Array is a class (reference type)
            // so when copied a reference (pointer, memory address) 
            // is set to the original object
            // pointer, memory address (reference) is copied not the value

            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");
        }
    }
}
