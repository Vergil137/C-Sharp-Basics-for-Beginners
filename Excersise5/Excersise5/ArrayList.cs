using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise5
{
    internal class ArrayList
    {
        public static void Exercise1()
        {
            var names = new List<string>();
            Console.WriteLine("Enter some names");

            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                names.Add(input);
            }

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(string.Format("{0} Likes your Post", names.First()));
                    break;
                case 2:
                    Console.WriteLine(string.Format("{0} and {1} Likes your Post", names[0], names[1]));
                    break;
                default:
                    Console.WriteLine(string.Format("{0}, {1} and {2} more Likes your Post", names[0], names[1], names.Count - 2));
                    break;
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter your Name");
            var name = Console.ReadLine();
            var array = name.ToCharArray();

            foreach (char c in array.Reverse())
            {
                Console.Write(c);
            }

            Console.WriteLine();
        }

        public static void Exercise3()
        {
            int[] numbers = new int[5];
            int i = 0;
            Console.WriteLine("Enter some numbers");
            while (i < numbers.Length)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(input))
                {
                    Console.WriteLine("Already entered Number, Retry");
                    continue;
                }

                numbers[i] = input;
                i++;
            }

            Array.Sort(numbers);

            Console.WriteLine("Your Numbers are: " + string.Join(", ", numbers));
        }

        public static void Exercise4()
        {
            var inputList = new List<int>();

            Console.WriteLine("Enter some Numbers");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }

                inputList.Add(Convert.ToInt32(input));
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                int index = inputList.LastIndexOf(inputList[i]);

                if (i != index)
                {
                    inputList.RemoveAt(index);
                    inputList.RemoveAt(i);
                }
            }

            Console.WriteLine("Uniques are: " + string.Join(", " , inputList));
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a List of numbers separeted by Comma");

            while (true)
            {
                var input = Console.ReadLine();
                var list = new List<int>();

                if (!string.IsNullOrEmpty(input))
                {
                    var array = input.Split(',');
                    foreach (var item in array)
                    {
                        list.Add(Convert.ToInt32(item));
                    }

                    if (list.Count >= 5)
                    {
                        list.Sort();

                        Console.WriteLine("Smallest values are: " + string.Join(", ", list.Take(3)));

                        return;
                    }
                }

                Console.WriteLine("Invalid List");
            }
        }

    }
}
