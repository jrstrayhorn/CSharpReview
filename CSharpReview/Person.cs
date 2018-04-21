using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Person
    {
        public DateTime Birthdate { get; set; } // C# compiler will automatically create private field

        /* Older Pre-C# Way
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        */

            // Using C#6
        public int Age => (DateTime.Today - Birthdate).Days / 365;
    }
}
