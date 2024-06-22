using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Cadidate
    {
        int id;
        String? Name;
        int Age;
        Double Weight;
        Double Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Id:");
            this.id =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            this.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight:");
            this.Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            this.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("<===============>");
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("Id:"+id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("weight:" + Weight);
            Console.WriteLine("Height:" + Height);
        }
    }
}
