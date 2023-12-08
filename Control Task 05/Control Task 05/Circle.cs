using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Task_05
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            if (r > 0)
            {
                radius = r;
            }
            else
            {
                Console.WriteLine("Incorrect value for the radius of the circle");
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius: {radius}");
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
