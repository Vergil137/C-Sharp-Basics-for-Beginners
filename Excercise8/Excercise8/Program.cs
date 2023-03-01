using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Excercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        static void Exercise1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        static void Exercise2()
        {
            Console.WriteLine("Enter a few Numbers separated by a hyphen");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = input.Split('-');
            var doubles = new List<int>();

            foreach (var number in numbers)
            {
                var num = Convert.ToInt32(number);
                if (doubles.Contains(num))
                {
                    Console.WriteLine("Duplicate");

                    return;
                }

                doubles.Add(num);
            }

            Console.WriteLine("All are Special");
        }

        static void Exercise3()
        {
            Console.WriteLine("Enter a 24-hour time");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !TimeSpan.TryParseExact(input, @"%h\:mm", null, out TimeSpan timeSpan))
            {
                Console.WriteLine("Invalid Time");

                return;
            }

            Console.WriteLine("Your entered Time is: " + timeSpan.ToString(@"hh\:mm"));
        }
        static void Exercise4()
        {
            Console.WriteLine("Enter some text");

            var input = Console.ReadLine();
            var str = new StringBuilder();

            foreach (var word in input.Split(' '))
            {
                str.Append(char.ToUpper(word[0]))
                   .Append(word.Substring(1).ToLower());
            }

            Console.WriteLine(str);
        }
        static void Exercise5()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            var vowelsCount = 0;

            Console.WriteLine("Enter an English Word");
            var input = Console.ReadLine().ToLower();

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine("{0} Vowels counted in Word '{1}'", vowelsCount, input);
        }
    }
}
