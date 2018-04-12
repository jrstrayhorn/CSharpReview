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
            var firstName = "JR";
            // each primitive type maps to struct in .NET framework
            // like int is System.Int32

            // string is a CLASS, both of these ways work
            string lastName = "Strayhorn";
            String anotherName = "Strayhorn"; // must add the System namespace to use this

            var myLastName = "Stray";

            //var fullName = firstName + " " + lastName; or
            //var fullName = string.Format("My name is {0} {1}", firstName, lastName); or
            var fullName = $"{firstName} {lastName}";

            // join
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // verbatim  \n - Is new line char
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2\folder3";

            Console.WriteLine(text);
        }
    }
}
