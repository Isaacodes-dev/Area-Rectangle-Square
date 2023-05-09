using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class Circle
    {
        public double radius;

        public double GetArea()
        {
            return Math.Round(value:Math.PI,digits:3) * radius * radius;
        }

        public void DisplayAreaofCircle()
        {
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"PI: {Math.Round(value:Math.PI,digits:3)}");
            Console.WriteLine($"Area of a Circle is {Math.Round(value:GetArea(),digits: 3)}");
            Console.WriteLine("Values Rounded off to 3 decimal places");
        }
    }
}
