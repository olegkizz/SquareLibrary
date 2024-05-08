using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new CircleException("Radius cant be negative");
            }
            this.radius = radius;   
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
