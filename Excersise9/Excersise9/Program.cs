using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Excersise9
{
    internal class Program
    {
        static string path = @"U:\testfile.txt";
        static void Main(string[] args)
        {
            Exercise1();
        }

        static void Exercise1()
        {
            var fileContent = File.ReadAllText(path);
            var words = fileContent.Split(' ');
            Console.WriteLine(words.Length);
        }

        static void Exercise2()
        {
            var fileContent = File.ReadAllText(path);
            var words = fileContent.Split(' ');
            var longestWord = "";
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
