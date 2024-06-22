using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Rectangle
    {
        Double length;
        Double breadth;
        public Rectangle(Double length, Double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public void AreaOfRect()
        {
            Double result = (this.length * this.breadth);
            Console.WriteLine("Area of Rectangle:: " + result);
        }
    }
}
