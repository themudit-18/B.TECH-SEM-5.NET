using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Distance
    {
        public Double Dist1;
        public Double Dist2;
        public Double Dist3;

        public Distance(Double d1, Double d2)
        {
            this.Dist1 = d1;
            this.Dist2 = d2;
        }
        public void totalDistance()
        {
            this.Dist3 = Dist1 + Dist2;
            Console.WriteLine("Calculated Distance::" + this.Dist3);
        }
    }
}
