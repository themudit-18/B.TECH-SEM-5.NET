using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public interface Gross
    {
        public void Gross_sal()
        {
            Console.WriteLine("Inside The Interface");
        }

    }
    internal class Salary_I
    {
        public String? HRA;
        public String? TA;
        public String? DA;
        public Salary_I(String? hRA, String? tA, String? dA)
        {
            this.HRA = hRA;
            this.TA = tA;
            this.DA = dA;
        }
        public void Disp_sal()
        {
            Console.WriteLine("Salary Of HRA::"+this.HRA);
            Console.WriteLine("Salary Of TA::" + this.TA);
            Console.WriteLine("Salary Of DA::" + this.DA);
        }
    }
    
    internal class Employee : Salary_I,Gross
    {
        public String? Name;

        public Employee(String? name, String? hRA, String? tA, String? dA)
            : base(hRA, tA, dA)
        {
            this.Name = name;
        }

        public void basic_sal(String? hRA, String? tA, String? dA, String? name)
        {
            this.HRA = hRA;
            this.TA = tA;
            this.DA = dA;
            this.Name = name;
        }

        public void Gross_sal()
        {
            Console.WriteLine("Inside The Interface Method");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Name: " + this.Name);
            Console.WriteLine("Basic Salary: " + Basic_sal());
            Disp_sal();
            Gross_sal();
        }

        public double Basic_sal()
        {

            return 30000.00;
        }
    }
}
