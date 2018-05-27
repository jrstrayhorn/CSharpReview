using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Stack
    {
        ArrayList _arrayList = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            _arrayList.Add(obj);
        }

        public object Pop()
        {
            if (_arrayList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var itemIndex = _arrayList.Count - 1;
            var returnObj = _arrayList[itemIndex];
            _arrayList.RemoveAt(itemIndex);
            return returnObj;
        }

        public void Clear()
        {
            _arrayList.Clear();
        }
    }
}
