using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Task_05
{
    class Square : Shape, IRotatable
    {
        private double side;

        public Square(double s)
        {
            if (s > 0)
            {
                side = s;
            }
            else
            {
                Console.WriteLine("Incorrect value for the side of the square");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Square with side: {side}");
        }

        public double CalculatePerimeter()
        {
            return 4 * side;
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public void Rotate()
        {
            Console.WriteLine("Square is rotating.");
        }
    }
}
