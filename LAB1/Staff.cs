using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Staff
    {
        String? Name;
        String? Department;
        String? Designation;
        Double Experience;
        Double Salary;


        Staff[] staff = new Staff[5];


        public void getStaffDetails()
        {
            for(int i = 0; i <staff.Length; i++)
            {
                staff[i] = new Staff();
                Console.WriteLine("Enter Name: ");
                staff[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Department Of: ");
                staff[i].Department = Console.ReadLine();
                Console.WriteLine("Enter Designation Of: ");
                staff[i].Designation = Console.ReadLine();
                Console.WriteLine("Enter Experience in Year:");
                staff[i].Experience=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Salary:");
                staff[i].Salary = Convert.ToDouble(Console.ReadLine());

            }
        }
        public void DisplayStaffDetails()
        {
            Console.WriteLine("=============");
            for (int i = 0; i < staff.Length; i++)
            {
                if (staff[i].Designation == "HOD")
                {
                    Console.WriteLine(staff[i].Name);
                    Console.WriteLine(staff[i].Department);
                }
            }
        }
    }
}
