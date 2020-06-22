using System;

namespace OperationsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var div = a / b;
            var remain = a % b;

            Console.WriteLine($"{a}/{b} is {div} with a remainder a {remain}");

            Console.WriteLine("Please Enter a two digit number for the radius of the circle");
           
            var r = double.Parse (Console.ReadLine());
            var pi = Math.PI;

            var circleArea = pi * (r * r);

            Console.WriteLine($"If the circle has a radius of {r}, the area of the circle based on its radius is - {circleArea}");

            int x = 5;
            int y = 5;

            int product = Multiply(x, y);
            Console.WriteLine($"The value of 5 multiplied by 5 is {product}");

            int quotient = Divide(x, y);
            Console.WriteLine($"The value of 5 divided by 5 is {quotient}");

            int add = Sum(x, y);
            Console.WriteLine($"The value of 5 plus 5 is {add}");

            int sub = Subtract(x, y);
            Console.WriteLine($"The value of 5 minus 5 is {sub}");
            
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
