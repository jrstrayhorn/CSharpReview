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
            // args => expression  args goes to expreession
            // number => number*number same as below method
            // compilter automatically can infer types

            // Func is a pointer to method that takes in types and return type
            // Action is a pointer to method that takes in types and return void

            // we are defining a delegate that will take an int as parameter and 
            // return an int
            //Func<int, int> square = Square;
            //Func<int, int> square = number => number * number;

            // No args () =>...
            // 1 arg x => ...
            // multiple args (x, y, z) => ...

            //Console.WriteLine(square(5));

            //const int factor = 5;

            //Func<int, int> multipler = n => n * factor;

            //var result = multipler(10);

            //Console.WriteLine(result);

            var books = new BookRepository().GetBooks();


        }

        //static int square(int number)
        //{
        //    return number * number;
        //}
    }
}
