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
            var path = @"c:\dev\testoutput.txt";

            //1- Write a program that reads a text file and displays the number of words.
            Console.WriteLine($"Number of words: {GetNumWordsFromFile(path)}");

            //2 - Write a program that reads a text file and displays the longest word in the file.
            Console.WriteLine($"Longest word: {GetLongestWordFromFile(path)}");
        }

        static string GetLongestWordFromFile(string path)
        {
            var longestWord = "";
            var currentLongestLength = 0;
            foreach (var word in File.ReadAllText(path).Split(' '))
            {
                var wordLength = word.Length;
                if (wordLength > currentLongestLength)
                {
                    longestWord = word;
                    currentLongestLength = wordLength;
                }
            }
            return longestWord;
        }

        static int GetNumWordsFromFile(string filePath)
        {
            return File
                   .ReadAllText(filePath)
                   .Split(' ')
                   .Length;
        }
    }
}
