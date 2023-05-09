using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class Square
    {
        public double length;

        public double GetArea()
        {
            return length * length;
        }

        public void DisplayAreaOfSquare()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Area of a Square is {GetArea()}");
        }
    }
}
