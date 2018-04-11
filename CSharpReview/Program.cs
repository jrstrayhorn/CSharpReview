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
            // DateTime is a struct
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine($"Hour: {now.Hour}");
            //Console.WriteLine($"Minute: {now.Minute}");

            // DateTimes are immutable can't change unless with method
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // Formatting to string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
