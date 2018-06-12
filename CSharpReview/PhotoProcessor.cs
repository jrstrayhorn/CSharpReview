using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class PhotoProcessor
    {
        // any functions that you point to via this delegate
        // must follow the method signature defined
        // in this case return type void with parameter of Photo
        // so, void DoSomething(Photo photo) this can be referenced
        // via this delegate
        //public delegate void PhotoFilterHandler(Photo photo);

        //public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            // this built-in delegate points to method(s) that return void
            //System.Action<>

            // this built-in delegate points to method(s) that return a value
            //System.Func<in T, out TResult>  TResult specify the return value

            // with these built in delegates theres really no reason to create
            // your own custom delegates

            var photo = Photo.Load(path);

            // client will define the filters that they want to use
            // now its extensible
            filterHandler(photo);

            // this code is NOT extensible
            // what if someone wants to define a
            // new filter that doesn't exist
            // for a new filter, we have to recompile the code
            // with delegate you can design
            // with extensibility in mind  (can also use an interface)
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}
