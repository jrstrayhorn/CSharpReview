using System.IO;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // File provide static methods - small methods against one file
            // FileInfo provide instance methods - if doing many operations against files

            var path = @"C:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...", true);

            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }
            
            // fileInfo has no readall method like File

        }
    }
}
