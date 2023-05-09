using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class Rectangle
    {
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {GetArea()}");
        }
    }
}
