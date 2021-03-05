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

            string result1 = Add(double.Parse(number1), double.Parse(number2));
            Console.WriteLine(result1);

            string result2 = Subtract(double.Parse(number1), double.Parse(number2));
            Console.WriteLine(result2);

            //Console.WriteLine(Add(double.Parse(number1), double.Parse(number2)));
            //Add(double.Parse("1"), 2); // convert string to double
            //Add(1, 2);

            Functions myFunctions = new Functions(9, 10); // call Functions from Functions.cs with input 2 & 3
            Console.WriteLine(myFunctions.Add(2, 3));
            Console.WriteLine(myFunctions.Subtract(2, 3));

            Functions myFunctions2 = new Functions(9, 10); // call Functions from Functions.cs with input 3 & 6
            Console.WriteLine(myFunctions2.Add(3, 6));
            Console.WriteLine(myFunctions2.Subtract(3, 6));
        }

        public static string Add(double a, double b)
        {
            return $"The sum of {a} and {b} is {Math.Round(a + b, 2)}.";
        }
        public static string Subtract(double a, double b)
        {
            return $"The subtraction of {a} and {b} is {Math.Round(a - b, 2)}.";
        }



    }
}
