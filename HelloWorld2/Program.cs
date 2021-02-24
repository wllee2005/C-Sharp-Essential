using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("William Lee!\nWelcome to C#Essentials.");

            string name = "Fritz " + "Lin"; // String concatenation
            double number1 = 20.5;
            int number2 = 10;
            string name2 = "William";
            bool flag = true;
            bool hasClassEnded = false;

            Console.WriteLine(name);
            Console.WriteLine(number1);
            // using positioning {} to place variables
            Console.WriteLine("Hello {0}! {1}! \n Welcome to C#Essentials.", name2, name);
            Console.WriteLine(flag);
            // $ to include variable in string
            Console.WriteLine($"Hello {name}!\nWelcome to C#Essentials.\nThe value of number1 is {number1}, and the value of number2 is {number2}");

            if (flag == !true) // ! is not so !true is false
            {
                Console.WriteLine("Hello !!!");
            }
            else if (hasClassEnded == true)
            {    Console.WriteLine("Bye !!!");
            }
            else if (name2 == "William")
            {
                Console.WriteLine("Your name is William");
            }
        }
    }
}
