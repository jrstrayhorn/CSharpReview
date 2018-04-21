using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Encapuslation should hide internal details
// should only show what they have, not how they get to it
namespace CSharpReview
{
    public class Person
    {
        private DateTime _birthdate;  // can't access birthdate outside the Person class

        public void SetBirthdate(DateTime birthdate)
        {
            // can implement logic about Birthdate here
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
