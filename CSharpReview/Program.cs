using CSharpReview.Math;
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
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }


    // Example of Struct, most of the time will use a class
    // but can use Struct if creating a light weight object
    // with few properties like a point (x,y)
    public struct RgbColor
    {
        public int Red;
        public int Green;
        public int Blue;
    }
}
