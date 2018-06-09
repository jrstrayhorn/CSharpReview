using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    // there is a problem with this implementation
    // we get a performance hit due to boxing/unboxing
    // from object to whatever is being passed
    public class List
    {
        public void Add(object item)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
