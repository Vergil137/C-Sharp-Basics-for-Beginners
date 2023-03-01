using System;

namespace Excersise5
{
    public class IfElse
    {

        public static void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 to 10");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 0 && input <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        public static void Exercise2()
        {
            int input1, input2, max;

            Console.WriteLine("Enter a number");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            input2 = Convert.ToInt32(Console.ReadLine());

            max = input1 > input2 ? input1 : input2;

            Console.WriteLine(string.Format("The greater value is {0}", max));
        }

        public static void Exercise3()
        {
            float width, height;
            Console.WriteLine("Enter Image Width");
            width = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Image Height");
            height = Convert.ToSingle(Console.ReadLine());

            if (width > height)
                Console.WriteLine("Image is Landscape");
            else
                Console.WriteLine("Image is Portrait");
        }

        public static void Exercise4()
        {
            int limit, speed;
            Console.WriteLine("Enter limit");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed");
            speed = Convert.ToInt32(Console.ReadLine());

            if (speed < limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int speedCounting = 5;
                int demeritPoint;
                demeritPoint = (speed - limit) / speedCounting;

                if (demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Your demerit Point is " + demeritPoint);
                }
            }
        }

        public static void Exercise3cop()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}