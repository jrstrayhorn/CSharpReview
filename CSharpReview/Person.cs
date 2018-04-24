using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    // classes should always be in a valid state
    // we've done that with private set
    // and removing the setter from Age
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        // C# 6 - you no longer need to add private set
        // for read-only auto-property
        public DateTime Birthdate { get; } // C# compiler will automatically create private field

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // Using C#6 - calculated property
        public int Age => (DateTime.Today - Birthdate).Days / 365;


        /* Older Pre-C#6 Way
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



    }
}
