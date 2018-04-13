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
            var hour = 10;

            // should always use curly braces make easy to read
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            // ternary conditional operator / shortcut for simple if/else
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                // stack case statements if you want to run code for
                // multiple conditions
                case Season.Summer:
                case Season.Autumn:
                    Console.WriteLine("We've got promotion");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's too cold!!");
                    break;
                
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
