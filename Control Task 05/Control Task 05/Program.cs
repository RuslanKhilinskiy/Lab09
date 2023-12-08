using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangleWithSides = new Triangle(3, 4, 5);
            triangleWithSides.OutputSidesValues();
            Console.WriteLine($"Perimeter: {triangleWithSides.PerimeterCount()}");
            Console.WriteLine($"Square: {triangleWithSides.SquareCount()}");

            Triangle equilateralTriangle = new Triangle(5);
            equilateralTriangle.OutputSidesValues();
            Console.WriteLine($"Perimeter: {equilateralTriangle.PerimeterCount()}");
            Console.WriteLine($"Square: {equilateralTriangle.SquareCount()}");

            Triangle myTriangle = new Triangle();
            myTriangle.InputSidesValues();
            myTriangle.OutputSidesValues();
            Console.WriteLine($"Perimeter: {myTriangle.PerimeterCount()}");
            Console.WriteLine($"Square: {myTriangle.SquareCount()}");

            Circle myCircle = new Circle(3);
            myCircle.DisplayInfo();
            Console.WriteLine($"Perimeter: {myCircle.CalculatePerimeter()}");
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");

            Square mySquare = new Square(4);
            mySquare.DisplayInfo();
            Console.WriteLine($"Perimeter: {mySquare.CalculatePerimeter()}");
            Console.WriteLine($"Area: {mySquare.CalculateArea()}");
            mySquare.Rotate();
        }
    }
}