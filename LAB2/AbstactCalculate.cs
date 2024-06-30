using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    abstract class AbstactCalculate
    {
        abstract public int SumOfTwo(int a, int b);
        abstract public int SumOfThree(int a, int b, int c);
    }
    internal class Calculate : AbstactCalculate
    {
        public override int SumOfTwo(int x, int y)
        {
            return x + y;
        }
        public override int SumOfThree(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
