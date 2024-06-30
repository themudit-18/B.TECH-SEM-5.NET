using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Student
    {
        List <string> l1 = new List<string>();
        //ArrayList StudentName = new ArrayList();


        //public void getArrayList()
        //{

        //    //this.StudentName.Add("Student1");
        //    //this.StudentName.Add("Student2");
        //    //this.StudentName.Add("Student3");
        //    //this.StudentName.Add("Student4");
        //    //this.StudentName.Remove("Student2");
        //    //this.StudentName.RemoveRange(0, 2);
        //    //this.StudentName.Clear();
        //}


        public void getList()
        {
            this.l1.Add("Student1");
            this.l1.Add("Student2");
            this.l1.Add("Student3");
            this.l1.Add("Student4");
            //this.l1.Remove("Student2");
            //this.l1.RemoveRange(0, 2);
            //this.l1.Clear();
        }
        public void Display()
        {
            for (int i = 0; i < this.l1.Count; i++)
            {
                Console.WriteLine(l1[i]);
            }
        }

    }
}
