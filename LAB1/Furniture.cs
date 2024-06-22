using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Furniture
    {
        public String Material;
        public Double Price;

        public Furniture(String material, Double price)
        {
            Material = material;
            Price = price;
        }
    }
    internal class Table:Furniture
    {
        public Double Height;
        public String Surface_area;

        public Table(Double height,String Surface,String material, Double price) :base(material, price)
        {
            this.Height = height;
            this.Surface_area = Surface;
        }
        public void display()
        {
            Console.WriteLine("Height:"+this.Height);
            Console.WriteLine("Surface_area:" + this.Surface_area);
            Console.WriteLine("Material:" + this.Material);
            Console.WriteLine("Price:" + this.Price);


        }

    }
}
