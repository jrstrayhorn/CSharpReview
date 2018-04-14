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
            // Loops - Program 1
            var count = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine(count);
            */

            /*
            // Loops - Program 2
            var userInput = "";
            var sum = 0;
            do
            {
                userInput = GetUserInput("Enter a number or type 'ok' to exit");
                if (userInput == "ok")
                {
                    break;
                }
                else
                {
                    sum += Int32.Parse(userInput);
                }
            } while (userInput != "ok");
            Console.WriteLine(sum);
            */

            /*
            // Loops - Program 3
            var startNumber = Int32.Parse(GetUserInput("Enter a number:"));
            var sum = startNumber;
            for (int i = startNumber-1; i > 0; i--)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
            */

            /*
            // Loops - Program 4
            const int MinValue = 1;
            const int MaxValue = 10;
            var randomNumber = new Random().Next(MinValue, MaxValue);
            Console.WriteLine(string.Format("Secret Number is {0}", randomNumber));
            bool guessCorrect = false;
            for (int i = 0; i < 4; i++)
            {
                var guess = Int32.Parse(GetUserInput(string.Format("Enter a guess between {0} and {1}:", MinValue, MaxValue)));
                if (guess == randomNumber) 
                {
                    guessCorrect = true;
                    Console.WriteLine("You won");
                    break;
                }
                    
            }
            if (!guessCorrect) {
                Console.WriteLine("You lost");
            }
            */

            
            // Loops - Program 5
            var numberString = GetUserInput("Enter a series of numbers separated by a comma");
            var numberArr = numberString.Split(',');
            int maxValue = Int32.Parse(numberArr[0]);
            int currValue;
            for (int i = 0; i < numberArr.Length; i++)
            {
                currValue = Int32.Parse(numberArr[i]);
                if (currValue > maxValue)
                    maxValue = currValue;
            }
            Console.WriteLine(maxValue);
            
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
