using System;
using System.Collections;
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
            var list = new ArrayList();
            list.Add(1);
            list.Add("JR");

            // this is bad
            // no type safety, will get errors at run time
            // another problem add method takes parameter of object
            // boxing will happen and cause performance hits

            var anotherList = new List<int>();
            // now this is type safe
            anotherList.Add(3);
            // no boxing b/c we store list of int




        }
    }
}
