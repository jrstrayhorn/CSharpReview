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
            var book = new Book { Isbn = "1111", Title = "C# Advanced", Price = 13.99F };

            var favBook = new Book { Isbn = "2233", Title = "C# Next Level", Price = 5.99F };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            // Now we have code reusablility
            // no casting or boxing
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            // this is where most generic in .NET is
            //System.Collections.Generic

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var bookUtilities = new Utilities<Book>();
            var maxBook = bookUtilities.Max(book, favBook);

            var number = new Nullable<int>(5);
            Console.WriteLine($"Has Value ?{number.HasValue}");
            Console.WriteLine($"Value: {number.GetValueOrDefault()}");
        }
    }
}
