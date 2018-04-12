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
            //// byte is 1 byte
            //byte b = 1;

            //// int is 4 byte we can convert w/o data loss
            //int i = b;

            //Console.WriteLine(i);

            //int i = 1;
            //byte b = i;  // implicit will not work because going from 4 byte to 1 byte - data loss may happen

            // will need to cast
            // but be careful if put to high a value some bits might be loss
            // like i = 1000; will lose some bits
            //byte b = (byte)i;

            try
            {
                //var number = "1234";  // var auto detect string type
                //                      //int i = (int)number; // will not work not compatible
                //                      //int i = Convert.ToInt32(number);  // this will work
                //byte b = Convert.ToByte(number);  // this will cause an exception because of overflow
                //                                  // value too large for byte
                //Console.WriteLine(b);

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            


        }
    }
}
