using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // overload
        public void Move(Point newLocation)
        {
            // defensive programming
            // improves robustness of code
            if (newLocation == null)
            {
                throw new ArgumentNullException(nameof(newLocation));
            }

            Move(newLocation.X, newLocation.Y);
        }
    }
}
