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
            // you must set a variable before you access it
            var number = 2; // var lets compiler detect datatype
            var count = 10; // by defualt compiler will assume int for integral numbers

            // by default compiler treats real numbers as double
            // need to explicit tell compiler this is a float with F
            var totalPrice = 20.95F;

            // char is a struct
            var character = 'A'; // use single quote

            // string is not a primative type
            var firstName = "Mosh"; // use double quote

            var isWorking = true; // either true or false (both keywords / lowercase)

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // Format string ie. template - showing range of byte
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            // or use String Interpolation via C#6 - this is more readable
            Console.WriteLine($"{byte.MinValue} {byte.MaxValue}");

            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // since const can't change later in program
            // if value can't change then use const
            const float Pi = 3.14f;

          
        }
    }
}
