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

            for (int j = 10; j >= 1; j--)
            {
                if (j%2 == 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
