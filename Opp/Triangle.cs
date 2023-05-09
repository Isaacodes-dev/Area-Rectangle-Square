using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class Triangle
    {
        public double length;
        public double bredth;

        public double GetArea()
        {
            return (length * bredth)/2;
        }

        public void DisplayAreaofTriangle()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {bredth}");
            Console.WriteLine($"Area of a Triangle is: {GetArea()}");
        }
    }
}
