using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class StudentStack
    {
        Stack<int> s1 = new Stack<int>();
        public void getStack()
        {
            //this.s1.Push("Student1");
            //this.s1.Push("Student2");
            //this.s1.Push("Student3");
            //this.s1.Push("Student4");
            //this.s1.Pop();
            this.s1.Push(10);
            this.s1.Push(20);
            this.s1.Push(30);
            this.s1.Push(40);
            //if (this.s1.Count > 0)
            //{
            //    int topItem = this.s1.Peek();
            //    Console.WriteLine($"Top item is {topItem}");
            //}
            //else
            //{
            //    Console.WriteLine("Stack is empty.");
            //}

            //Console.WriteLine(this.s1.Contains(40));
            this.s1.Clear();
        }

        public void display()
        {
            
            foreach (var item in this.s1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
