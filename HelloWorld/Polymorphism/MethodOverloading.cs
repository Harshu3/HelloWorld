using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Polymorphism
{
    internal class Addition
    {
        public void AddNumbers(int first, int second)
        {
            Console.WriteLine("Sum of numbers: " + first + second);
        }

        //varrying number of parameters compared to 1st method
        public void AddNumbers(int first, int second, int third)
        {
            Console.WriteLine("Sum of numbers: " + (first + second + third));
        }

        //changing datatype compared to 2nd method
        public void AddNumbers(int first, double second, int third)
        {
            double res = first + second + third;
            Console.WriteLine("Sum of numbers: " + res);
        }

        //changing order compared to 3rd method
        public void AddNumbers(double second, int first, int third)
        {
            double res = first + second + third;
            Console.WriteLine("Sum of numbers: " + res);
        }
    }
}
