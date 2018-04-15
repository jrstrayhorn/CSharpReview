using System;
using System.Text;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Program 1
            //var userInput = GetUserInput("Enter a few numbers separated by a hyphen");
            //Console.WriteLine(
            //    CheckInputForConsecutive(userInput) 
            //    ? 
            //    "Consecutive" : "Not Consecutive"
            //    );

            //// Program 2
            //var userInput = GetUserInput("Enter a few numbers separated by a hyphen");

            //if (String.IsNullOrWhiteSpace(userInput))
            //{
            //    return;
            //}

            //if (CheckInputForDuplicates(userInput))
            //{
            //    Console.WriteLine("Duplicate");
            //}

            //// Program 3
            //var userInput = GetUserInput("Enter a time value in the 24-hour time format");
            //Console.WriteLine(
            //     CheckForValidTimeFormat(userInput)
            //    ? 
            //    "Ok" : "Invalid Time"
            //    );

            //// Program 4
            //var userInput = GetUserInput("Enter a few words separated by a space");
            //Console.WriteLine(GetPascalCase(userInput));

            // Program 5
            var userInput = GetUserInput("Enter an English word");
            Console.WriteLine(GetVowelCount(userInput));
        }

        public static int GetVowelCount(string userInput)
        {
            var input = new StringBuilder(userInput);

            var origLength = input.Length;

            var newLength = input
                                .Replace("a", String.Empty)
                                .Replace("e", String.Empty)
                                .Replace("i", String.Empty)
                                .Replace("o", String.Empty)
                                .Replace("u", String.Empty)
                                .Length;

            return origLength - newLength;
        }

        public static StringBuilder GetPascalCase(string userInput)
        {
            var inputArr = userInput.ToLower().Split(' ');

            var result = new StringBuilder();

            foreach (var input in inputArr)
            {
                result
                    .Append(input.ToUpper()[0])
                    .Append(input.Substring(1));
            }

            return result;
        }

        public static bool CheckForValidTimeFormat(string userInput)
        {
            var dtResult = new DateTime();
            return DateTime.TryParse(userInput, out dtResult);
        }

        public static bool CheckInputForDuplicates(string userInput)
        {
            var inputArr = userInput.Split('-');
            Array.Sort(inputArr);

            for (int i = 1; i < inputArr.Length-1; i++)
            {
                if (inputArr[i-1] == inputArr[i])
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static bool CheckInputForConsecutive(string userInput)
        {
            var inputArr = userInput.Split('-');
            var firstNum = Convert.ToInt32(inputArr[0]);
            var lastNum = Convert.ToInt32(inputArr[inputArr.Length - 1]);

            if (firstNum < lastNum)
            {
                var check = firstNum;
                foreach (var input in inputArr)
                {
                    if (check != Convert.ToInt32(input))
                    {
                        return false;
                    }
                    check++;
                }
            }
            else
            {
                var check = firstNum;
                foreach (var input in inputArr)
                {
                    if (check != Convert.ToInt32(input))
                    {
                        return false;
                    }
                    check--;
                }
            }

            return true;
        }
    }
}
