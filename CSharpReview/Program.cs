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
            /*
            // Lists - Exercise 1
            string userName = "";
            var nameList = new List<string>();
            do
            {
                userName = GetUserInput("Enter a name, press Enter to stop");
                if (!string.IsNullOrWhiteSpace(userName))
                    nameList.Add(userName);

            } while (!string.IsNullOrWhiteSpace(userName));

            var friendCount = nameList.Count;

            if (friendCount == 0)
            {
                Console.WriteLine("");
            }
            else if (friendCount == 1)
            {
                Console.WriteLine(string.Format("{0} likes your post",nameList[0]));
            }
            else if (friendCount == 2)
            {
                Console.WriteLine(string.Format("{0} and {1} like your post", nameList[0], nameList[1]));
            }
            else if (friendCount > 2)
            {
                Console.WriteLine(string.Format("{0}, {1} and {2} others like your post", nameList[0], nameList[1], friendCount - 2));
            }
            */

            //// Lists - Exercise 2
            //var userName = GetUserInput("What is your name?");

            //var userNameArr = userName.ToCharArray();

            //Array.Reverse(userNameArr);

            //var reverseUserName = String.Join("", userNameArr);

            //Console.WriteLine(reverseUserName);

            /*
           // Array - Program 3
           var numList = new List<int>();

           while (numList.Count < 5) {
               var num = Int32.Parse(GetUserInput("Enter a number"));
               if (numList.Contains(num))
               {
                   Console.WriteLine("Number already entered.  Please try again.");
               }
               else
               {
                   numList.Add(num);
               }
           }

           numList.Sort();

           foreach (var num in numList)
           {
               Console.WriteLine(num);
           }
           */

            /*
            // Array - Program 4
            var numList = new List<int>();
            var entry = "";

            while (entry != "quit")
            {
                entry = GetUserInput("Enter a number");
                if (entry != "quit")
                {
                    var numEntry = Int32.Parse(entry);
                    if (!numList.Contains(numEntry))
                        numList.Add(Int32.Parse(entry));
                }
            }

            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }
            */

            // Array - Program 5
            var arrLength = 0;
            var numberList = new List<int>();
            do
            {
                var numberString = GetUserInput("Enter a series of numbers separated by a comma");
                var numberArr = numberString.Split(',');
                arrLength = numberArr.Length;
                if (numberArr.Length < 5)
                {
                    Console.WriteLine("Invalid List");

                }
                else
                {
                    foreach (var num in numberArr)
                    {
                        numberList.Add(Int32.Parse(num));
                    }
                }
            } while (arrLength < 5);

            numberList.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
