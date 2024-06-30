using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public interface ShapeInterface
    {
        double Circle(double Radius);

        double Triangle(double Base, double Height);

        double Square(double Side);
    }

    internal class Shape : ShapeInterface
    {
        public double Circle(double Radius)
        {
            return Math.PI * Radius * Radius;
        }

        public double Square(double Side)
        {
            return Side * Side;
        }

        public double Triangle(double Base, double Height)
        {
            return (0.5 * Base * Height);
        }
    }
}
