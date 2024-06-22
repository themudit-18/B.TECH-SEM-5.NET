using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Salary
    {
        public Double Basic;
        public Double TA;
        public Double DA;
        public Double HRA;
        public Double CalSalary;

        public Salary(Double basic, Double ta, Double da = 5000, Double hra = 3000)
        {
            this.Basic = basic;
            this.TA = ta;
            this.DA = da;
            this.HRA = hra;
        }

        public void CalculateTotalSalary()
        {
            this.CalSalary = Basic + TA + DA + HRA;
            Console.WriteLine("Calculated Salary::" + this.CalSalary);
        }
    }
}
