using System;

namespace Box
{

    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box(1, 2, 3);
            Console.WriteLine($"The volume of the box is {Box1.getVolume()}.");

            Box Box2 = new Box(3);
            Console.WriteLine($"The volume of the box is  {Box2.getVolume()}");
        }
    }
}
