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
            // creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);

            // this one is more readable
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine($"duration: {duration}");

            // properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // timespan is immutable, need to use methods to change
            // add
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            // sub
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // tostring
            Console.WriteLine("ToString" + timeSpan.ToString());

            // parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
