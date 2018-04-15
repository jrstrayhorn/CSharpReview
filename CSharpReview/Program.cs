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
            // StringBuilder can be used when you need to manipulate strings in code
            // Since String is immutable, StringBuilder gives you a way to change strings
            // on the fly, the tradeoff is that you aren't able to search in the strings
            // with IndexOf type methods
            var builder = new StringBuilder("Hello World");

            // can chain these methods because they return a stringbuilder
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            // stringbuilder is faster than regular string manipulation
            // bc regular string manipulation creates new strings in memory
            // but again no string searching

            Console.WriteLine("Fifth Char: " + builder[4]);
        }
    }
}
