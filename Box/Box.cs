using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{

    public class Box
    {
        double _width;
        double _length;
        double _height;

        private static int _counter = 0;

        public Box(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;

            _counter++; //_counter = _counter + 1

            Console.WriteLine($"A box of dimensions {_length}, {_width}, {_height} has been created.");
            Console.WriteLine($"The number of boxes created is {_counter}.");
        }

        public Box(double length) // Polymorphism
        {
            _width = _length = _height = length;
            _counter++;

            Console.WriteLine($"A box of dimensions {_length}, {_width}, {_height} has been created.");
            Console.WriteLine($"The number of boxes created is {_counter}.");
        }
            public double getVolume()
        {
            return _length * _width * _height;
        }
    }

}
