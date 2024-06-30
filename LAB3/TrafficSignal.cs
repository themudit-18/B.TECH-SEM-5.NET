using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public delegate void TrafficDel();
    internal class TrafficSignal
    {
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }

        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }

        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }
    }
}
