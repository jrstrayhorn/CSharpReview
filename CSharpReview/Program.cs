﻿using System;
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
            string post = "This is supposed to be a very long blog post blah blah...";
            var shortenedPost = post.Shorten(7);
            Console.WriteLine(shortenedPost);
            Console.ReadKey();
        }
    }


}
