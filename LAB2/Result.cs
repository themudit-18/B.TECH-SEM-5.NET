using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    interface CalculateAll
    {
        public void Addition();
        public void Subtraction();
    }
    internal class Result : CalculateAll
    {
        public void Addition()
        {
            int a = 210;
            int b = 304;
            int Result = a + b;
            Console.WriteLine("Addition is :: " + Result);
        }

        public void Subtraction()
        {
            int a = 210;
            int b = 304;
            int Result = a - b;
            Console.WriteLine("Subtraction is :: " + Result);
        }
    }
}
