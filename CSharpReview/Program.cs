using System;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Exercises
            /* - Program 1
            Console.WriteLine("Please enter a number:");
            var input = Console.ReadLine();

            var DisplayMessage = Int32.Parse(input) > 10 ? "Invalid" : "Valid";
            Console.WriteLine(DisplayMessage);
            */

            /* - Program 2
            Console.WriteLine("Enter number 1:");
            var input1 = Console.ReadLine();

            Console.WriteLine("Enter number 2:");
            var input2 = Console.ReadLine();

            var maxNum = Int32.Parse(input1) > Int32.Parse(input2) ? input1 : input2;
            Console.WriteLine(maxNum);
            */

            /* - Program 3
            var imageWidth = GetUserInput("Enter the image width:");
            var imageHeight = GetUserInput("Enter the image height:");
            Console.WriteLine(string.Format("The image is {0}", 
                                            Int32.Parse(imageWidth) > Int32.Parse(imageHeight) ? 
                                            "landscape" : 
                                            "portrait"));
            */

            // - Program 4
            var speedLimitInput = GetUserInput("Enter the speed limit:");
            var carSpeedInput = GetUserInput("Enter the car speed:");
            var speedLimit = Int32.Parse(speedLimitInput);
            var carSpeed = Int32.Parse(carSpeedInput);

            if (carSpeed < speedLimit) 
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var milesAboveSpeedLimit = carSpeed - speedLimit;
                var demeritPoints = milesAboveSpeedLimit / 5;
                if (demeritPoints <= 12 && demeritPoints >= 0)
                {
                    Console.WriteLine($"Demerit Points: {demeritPoints}");
                } 
                else if (demeritPoints > 12) 
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
