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

            // Find, FindAll needs a predicate, which is a generic
            // that points to a method that takes in a T (whatever)
            // and return a boolean if matched or not
            // all Find, FindAll, FindIndex, etc
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            // This lambda expression is the same as the predicate method below
            // book goes to book.Price is less than 10
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        // predicate method
        // using this method, FindAll method will iterate through list
        // passing each item of list to method and return a boolean
        // to see if item should be returned or not
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        //static int square(int number)
        //{
        //    return number * number;
        //}
    }
}
