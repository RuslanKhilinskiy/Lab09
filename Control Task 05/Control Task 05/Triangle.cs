﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Control_Task_05
{
    class Triangle : Shape
    {
        private double sideA, sideB, sideC;

        public Triangle(double a, double b, double c)   // Конструктор для создания треугольника с заданными длинами сторон
        {
            if (TriangeCheck(a, b, c))
            {
                sideA = a;
                sideB = b;
                sideC = c;
            }
            else
            {
                Console.WriteLine("Incorrect values of the triangle's sides");
            }
        }
        public Triangle(double sideLength)  // Конструктор для создания равностороннего треугольника
        {
            if (sideLength > 0)
            {
                sideA = sideB = sideC = sideLength;
            }
            else
            {
                Console.WriteLine("Incorrect value for the side length of the equilateral triangle");
            }
        }
        public Triangle()
        {
            sideA = sideB = sideC = 0;
        }
        public bool InitializingSides(double a, double b, double c) //инициализация сторон треугольника и проверка на коррекность введенных сторон
        {
            if (TriangeCheck(a, b, c))
            {
                sideA = a;
                sideB = b;
                sideC = c;
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect values of the triangle's sides");
                return false;
            }
        }
        public void InputSidesValues() //метод ввода значений сторон треугольника
        {
            Console.WriteLine("Enter the value of the first side: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of the second side: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of the third side: ");
            double c = Convert.ToDouble(Console.ReadLine());

            InitializingSides(a, b, c);
        }
        public double PerimeterCount() //вычисление периметра треугольника
        {
            return sideA + sideB + sideC;
        }
        public double SquareCount() //вычисление площади треугольника
        {
            double square = PerimeterCount() / 2;
            return Math.Sqrt(square * (square - sideA) * (square - sideB) * (square - sideC));
        }
        public void OutputSidesValues() //метод вывода значений сторон треугольника
        {
            Console.WriteLine($"The first tiangle's side: {sideA}");
            Console.WriteLine($"The second tiangle's side: {sideB}");
            Console.WriteLine($"The third tiangle's side: {sideC}");
        }
        private bool TriangeCheck(double a, double b, double c) //метод проверки корректности введенных значений сторон треугольника
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
