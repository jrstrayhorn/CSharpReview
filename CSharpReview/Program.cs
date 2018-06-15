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
            var books = new BookRepository().GetBooks();

            //// LINQ Query Operators
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b.Title;

            //// LINQ Extension Methods
            //var cheapBooks = books
            //        .Where(b => b.Price < 10)
            //        .OrderBy(b => b.Title)
            //        .Select(b => b.Title);

            // OLD NON LINQ WAY - DONT DO THIS :)
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book);
            //}

            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(book?.Title ?? "Book not found");

            book = books.FirstOrDefault(b => b.Title == "C# Advanced Topicss");
            Console.WriteLine(book?.Title + " " + book?.Price ?? "Book not found");

            // .SingleOrDefault
            // .LastOrDefault
            // .FirstOrDefault

            var pagedBooks = books.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }
        }
    }
}
