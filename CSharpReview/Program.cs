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
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            // random number between 1 and 10
            //random.Next(1, 10);

            Console.WriteLine((int)'a');  // 97 which represent lower case a on computer
                                          // ascii-code.com leter to number conversion

            // generate random password
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)('a' + random.Next(0, 26)));  
                // will result in number between a and z
            }

            var password = new string(buffer);
            Console.WriteLine(password);
            
        }
    }
}
