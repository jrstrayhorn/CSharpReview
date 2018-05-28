using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Rectangle : Shape
    {
        // oops don't override Draw here
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
