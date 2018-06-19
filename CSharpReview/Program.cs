using System;
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
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

                var content = streamReader.ReadToEnd();
            }
            //catch(DivideByZeroException ex) // most specific
            //{
            //    // can do something specific to this exception
            //    Console.WriteLine("You cannot divide by 0.");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            catch (Exception ex) // most generic, if this was first would hit any other catch block.
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {
                // manual clean up
                // files, database, network connection, graphics
                // make sure to dispose with .Dispose()
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }
            }

            // a cleaner way to write the above
            try
            {
                //using (var myReader = new StreamReader(@"c:\file.zip"))
                //{
                //    var content = myReader.ReadToEnd();
                //}
                var api = new YouTubeApi();
                var videos = api.GetVideos("jr");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, an unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }


        }
    }
}
