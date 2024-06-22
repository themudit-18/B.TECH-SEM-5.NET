using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Student
    {
        int Enrollment;
        String Name;
        int Semester;
        double CPI;
        double SPI;

        public Student(int Enrollment, String Name, int Semester, double CPI, double SPI)
        {
            this.Enrollment = Enrollment;
            this.Name = Name;
            this.Semester = Semester;
            this.CPI = CPI;
            this.SPI = SPI;
        }

        public void Display()
        {
            Console.WriteLine("<========Student Detail's========>");
            Console.WriteLine("Enrollment:" + this.Enrollment);
            Console.WriteLine("Name:" + this.Name);
            Console.WriteLine("Semester:" + this.Semester);
            Console.WriteLine("CPI:" + this.CPI);
            Console.WriteLine("SPI:" + this.SPI);
        }
    }
}
