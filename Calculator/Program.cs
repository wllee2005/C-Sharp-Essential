using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string number2 = Console.ReadLine();

            double result = Add(double.Parse(number1), double.Parse(number2));
            Console.WriteLine(result);

            //Console.WriteLine(Add(double.Parse(number1), double.Parse(number2)));
            //Add(double.Parse("1"), 2); // convert string to double
            //Add(1, 2);
        }
            
            public static double Add(double a, double b) // void changed to double since there's a return
        {
            //Console.WriteLine($"The sum of {a} and {b} is {a + b}");
            //Console.WriteLine($"The sum of {a} and {b} is {Math.Round(a + b, 2)}");
            return Math.Round(a + b, 2); // return a double
        }
    }
}
