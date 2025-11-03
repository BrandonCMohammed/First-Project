using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    class Program
    {
        static void foreachTesting()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            foreach (int n in matrix)
            {
                Console.WriteLine(n);
            }

        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Red", 2020);
            Console.WriteLine(myCar.Color);
            Console.WriteLine(myCar.Year);

            // myCar.Color = "Blue";
            // Console.WriteLine(myCar.Color);

            // int a = 5;
            // Console.WriteLine("Hello, World! " + a);
            // string name = Console.ReadLine();
            // Console.WriteLine($"Hello {name}!");

            // foreachTesting();

            // if (a > 3)
            // {
            //     Console.WriteLine("a is greater than 3");
            // }
            // else
            // {
            //     Console.WriteLine("a is not greater than 3");
            // }

            // Console.WriteLine(a > 4 ? "a is greater than 4" : "a is not greater than 4");

        }
    }

    class Car
    {
        public Car(string color, int year)
        {
            Color = color;
            Year = year;
        }

        public string Color
        {
            get;
            set;
        }

        public int Year
        {
            get;
            set;
        }


    }
}

/*
Math functions in C#:
1. Manth.Max(x, y): Returns the larger of x and y.
2. Math.Min(x, y): Returns the smaller of x and y.
3. Math.Sqrt(x): Returns the square root of x.
4. Math.Pow(x, y): Returns x raised to the power of y.
1. Math.Abs(x): Returns the absolute value of x.
2. Math.Round(x): Rounds x to the nearest integer. 

*/