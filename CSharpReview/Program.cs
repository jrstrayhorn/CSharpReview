using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryStopwatch();
            TryPost();
        }

        private static void TryPost()
        {
            var post = new Post()
            {
                Title = "New Post",
                Description = "Here is a new post."
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();

            Console.WriteLine($"Number of votes: {post.Votes}");
        }

        private static void TryStopwatch()
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine(stopwatch.Duration);

            stopwatch.Start();

            Console.WriteLine("Pausing for 10 seconds");
            Thread.Sleep(10000);

            stopwatch.Stop();

            Console.WriteLine($"Duration: {stopwatch.Duration}");

            stopwatch.Start();

            Console.WriteLine("Pausing for 5 seconds");
            Thread.Sleep(5000);

            stopwatch.Stop();
            stopwatch.Stop();

            Console.WriteLine($"Duration: {stopwatch.Duration}");

            //stopwatch.Start();
            //stopwatch.Start();
        }
    }
}
