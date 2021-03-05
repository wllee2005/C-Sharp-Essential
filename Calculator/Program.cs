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

            Add(int.Parse(number1), int.Parse(number2));
            //Add(double.Parse("1"), 2); // convert string to double
            //Add(1, 2);
        }
            
            public static void Add(double a, double b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
           
        }
    }
}
