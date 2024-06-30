using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Area
    {
        public double CalculateArea(double side)
        {
            return side * side;
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

         public double CalculateArea(double radius, bool isCircle)
        {
            return Math.PI * radius * radius;
        }
    }
}
