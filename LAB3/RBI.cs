using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class RBI
    {
        public virtual void CalculateInterest(double P, double R, double T)
        {
            double Rate = (P * R * T) / 100;
            Console.WriteLine(Rate);
        }
    }

    class HDFC : RBI
    {
        public override void CalculateInterest(double P, double R, double T)
        {
            double Rate = (P * R * T) / 100;
            Console.WriteLine(Rate);
        }
    }

    class SBI : RBI
    {
        public override void CalculateInterest(double P, double R, double T)
        {
            double Rate = (P * R * T) / 100;
            Console.WriteLine(Rate);
        }
    }

    class ICICI : RBI
    {
        public override void CalculateInterest(double P, double R, double T)
        {
            double Rate = (P * R * T) / 100;
            Console.WriteLine(Rate);
        }
    }
}
