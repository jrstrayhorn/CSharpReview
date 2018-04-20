using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        /*
         F9 - Place/Remove Breakpoint
         F5 - Start Debugging
         Shift + F5 - Stop Debug Session
         F10 - Step over (goes to next line in execution)
         F11 - Step into (goes into the method)
         Shift-F11 - Step out of a method
        use yellow arrow to move debug line

        F5 - will continue to the next breakpoint during debug


        DEBUG / Windows / Watch / Ctrl+D, W
        Use Watch window to view variables 
        that you can specify during code
        execution

        Auto - Ctrl+D, A
        Use Auto window to view variables that 
        Visual Studio will automatically display
        based on surround variables

        Locals - Ctrl+D, L
        Use Locals window to view variables that
        are in local scope to line of code debugging

        Good programmers think of edge cases
        Uncommon scenarios - don't assume users will put
        in correct values;

            Ctrl+D, B - show Breakpoint debug window
                allow to quickly disable breakpoints

        Defensive Programming - if inputs dont fit, throw exception
        
    */
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 }; // 2 values will give out of range exception
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        // This method had a side effect.. not good
        // makes method unreliable
        // this method is changing the original list
        public static List<int> GetSmallests(List<int> list, int count)
        {
            // defensive programming tip:
            // check the element before doing processing
            // make sure that the application doesn't go
            // in the wrong state

            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");
            }

            var buffer = new List<int>(list); // a copy of original list for processing
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            // to fix could you conditional here to check for empty list
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }

    }
}
