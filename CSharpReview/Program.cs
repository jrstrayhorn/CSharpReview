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
            for (int i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // can use while loops for for-loops as well
            // for loops is good when you know how many times
            // you want to iterate
            // typically use while loop when you don't know
            // ahead of time how many iterations
            var i = 0;
            while (i <= 10)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }

            // means will run forever
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine("@Echo: " + input);
            }

            // means will run forever
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; // will go back to the beginning of the loop
                }

                break;
            }


        }
    }
}
