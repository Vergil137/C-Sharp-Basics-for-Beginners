using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise5
{
    internal class Iteration
    {
        public static void Exercise1()
        {
            int divider = 3;
            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % divider == 0 && i > 0)
                    counter++;
            }

            Console.WriteLine(counter);
        }

        public static void Exercise2()
        {
            string input;
            int sum = 0;

            Console.WriteLine("Enter a number to calculate or \"OK\" to exit");
            do
            {
                int buffer;
                input = Console.ReadLine();
                if (int.TryParse(input, out buffer))
                    sum += buffer;
            } while (input != "ok");

            Console.WriteLine("The Sum of the entered numbers is: " + sum);
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a number for factorial");
            int input = Convert.ToInt32(Console.ReadLine());
            int fac = 1;

            for (int i = input; i > 0; i--)
            {
                fac *= i;
            }

            Console.WriteLine("{0}! = {1} ", input, fac);
        }

        public static void Exercise4()
        {
            int rand = new Random().Next(1, 10);
            int tries = 4;
            int input = 0;
            bool guessed = false;
            Console.WriteLine("Guess the secret number between 1 an 10. You got 4 tries");

            while (!guessed && tries > 0)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input == rand)
                    guessed = true;
                tries--;
            }

            if (guessed)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You Lost");
            }

            Console.WriteLine("The Secret number was " + rand);
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a siries of numbers seperated by comma");

            var input = Console.ReadLine();
            string[] array = input.Split(new string[] { ",", ", " }, StringSplitOptions.None);
            int[] list = Array.ConvertAll(array, s => int.Parse(s));
            Console.WriteLine("Biggest Value is: " + list.Max());
            Console.WriteLine("Your list was: " + String.Join(", ", list));
        }
    }
}
