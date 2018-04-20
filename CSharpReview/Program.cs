using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            return new Person() { Name = str };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person(); // compile will figure out the type
            var person = Person.Parse("John");
            //person.Name = "John";
            person.Introduce("Mike");
        }
    }
}
