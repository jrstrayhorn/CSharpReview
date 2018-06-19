using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        static async void Main(string[] args)
        {
            //DownloadHTMLAsync("www.bing.com");
            //var html = await GetHtmlAsync("http://msdn.microsoft.com");

            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            // can do work not dependent on async call, will get called
            Console.WriteLine("another message");

            
            var html = await getHtmlTask;

            // the rest of this method wont get called until await task above is completed
            Console.WriteLine(html.Substring(0, 10));
        }

        public static async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        // task encapuslate state of async action, either generic for other types or non-generic for returning void
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();

            // await is a marker for compiler
            // it knows that operation may take time
            // don't block the thread, return to caller of the method
            var html = await webClient.DownloadStringTaskAsync(url);


            // compiler creates the rest of this method as a callback
            // from the above call
            using (var streamWriter = new StreamWriter(@"C:"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHTML(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
