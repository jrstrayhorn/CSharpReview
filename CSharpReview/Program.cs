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
            // this wont work
            //DateTime date = null;

            //Nullable<DateTime> date = null;

            // shorthand

            DateTime? date = null;

            Console.WriteLine($"GetValueOrDefault(): {date.GetValueOrDefault()}");
            Console.WriteLine($"HasValue: {date.HasValue}");

            // this will cause an exception because value is null
            // we cant access value
            // use GetValueOrDefault to get value its safer
            Console.WriteLine($"Value: {date.Value}");

            DateTime? newTime = new DateTime(2014, 1, 1);
            //DateTime date2 = date; // this is an error, can't put nullable datetime into datetime
            DateTime date2 = date.GetValueOrDefault();  // this will work, helpful when getting stuff from DB

            DateTime? date3 = date2; // this will work because will always be a datetime

            Console.WriteLine(date3.GetValueOrDefault());

            // Null Coalescing Operator

            DateTime? date4 = null;
            DateTime date5;

            // we can rewrite this
            //if (date != null)
            //{
            //    date2 = date.GetValueOrDefault();
            //}
            //else
            //{
            //    date2 = DateTime.Today;
            //}

            date2 = date ?? DateTime.Today;

            // same as
            DateTime date6 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}
