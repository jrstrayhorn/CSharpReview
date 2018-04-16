using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        // rule of thumb separater code that works
        // with console from code that works with
        // logic
        // real world hae different presentation
        // extracting logic will allow reusability
        // console only relevant in console
        
        // responsible for getting input and display output
        static void Main(string[] args)
        {
            // get user name
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            // reverse logic
            var reversed = ReverseName(name);

            // show on console
            Console.WriteLine("Reversed name: " + reversed);
        }
        
        // use meaningful method name
        // responsible for reversing
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            return new string(array);
        }
    }
}
