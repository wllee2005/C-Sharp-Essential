using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your Age: ");
            string age = Console.ReadLine();
            
            Console.WriteLine($"Your Name is {name} and Age is : {age} ");
        }
    }
}
