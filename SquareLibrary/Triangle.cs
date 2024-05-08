using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            IsCorrect();
        }
        public Triangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            IsCorrect();
        }
        public override double Area()
        {
            double halfPer = (a + b + c) / 2;

            return Math.Sqrt(halfPer*(halfPer - a) * (halfPer - b)
                   * (halfPer - c));
        }

        public bool IsCorrect()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new TriangleException(
                    "Sum of two lines bigger than third.");
            }
            return true;
        }
        public bool IsSquare()
        {
            double squareA = Math.Pow(a, 2);
            double squareB = Math.Pow(b, 2);
            double squareC = Math.Pow(c, 2);
            return squareA + squareB == squareC ||
                squareC + squareA == squareB ||
                squareB+ squareC == squareA;
        }
    }
}
