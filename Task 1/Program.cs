﻿/*
 * Developed by Faridun Berdiev
 * Date: 02.04.2020
 * First Task
*/
using System;

namespace Task_1
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double Area { 
            get 
            {
                return AreaCalculator(); 
            }
        }
        public double Perimeter { 
            get 
            {
                return PerimeterCalculator(); 
            }
        }
        public Rectangle(double _side1, double _side2)
        {
            this.side1 = _side1;
            this.side2 = _side2;
        }

        private double AreaCalculator()
        {           
            return this.side1 * this.side2;
        }

        private double PerimeterCalculator()
        {           
            return 2 * (this.side1 + this.side2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine().Replace(".", ","));
            double B = double.Parse(Console.ReadLine().Replace(".", ","));

            Rectangle rect = new Rectangle(A, B);
            Console.WriteLine("AREA: " + rect.Area);
            Console.WriteLine("PERIMETER: " + rect.Perimeter);
        }
    }
}
