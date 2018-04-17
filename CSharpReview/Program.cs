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
            // Directory provide static methods
            // Directory provide instance methods

            Directory.CreateDirectory(@"c:/somepath");

            var files = Directory.GetFiles(@"c:\projects\coding", "*.exe", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\coding", "*.*", SearchOption.AllDirectories);

            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
