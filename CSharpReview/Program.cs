using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);  // text and shape are both pointing to the same object, with different views

            //StreamReader reader = new StreamReader(new MemoryStream());  // MemoryStream automatically upcast to Stream

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("string");
            //list.Add(new Text());
            //// don't do this, b/c not type safe, will get exceptions

            //var anotherList = new List<Shape>();

            Shape shape = new Text();  // at run time type for Shape will be text
            Text text = (Text)shape;  // now have all properties of Text class

            // Need to downcast when parameter/argument of method is object
            // object only has limited properties so you need to cast object to 
            // certain Type

            // if you aren't sure of type cast use as
            // like var button = sender as Button;
            // then can check for null if (button != null)
        }
    }
}
