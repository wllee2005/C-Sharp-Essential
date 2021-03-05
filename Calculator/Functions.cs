using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Functions
    {
        //Fields
        private double _num1;
        private double _num2;
        public Functions(double a, double b) // aka Constructor
        {   _num1 = a;
            _num2 = b;
        }

        public string Add(double a, double b) 
        {
            return $"The sum of {a} and {b} is {Math.Round(a + b, 2)}.\n And the values of _num1 and _num2 are {_num1} and {_num2}";
        }
        public string Subtract(double a, double b) 
        {
            return $"The subtraction of {a} and {b} is {Math.Round(a - b, 2)}.\n And the values of _num1 and _num2 are {_num1} and {_num2}";
        }
    }
}
