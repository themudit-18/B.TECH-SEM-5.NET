using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class StudentQueue
    {
        Queue<int> q1 = new Queue<int>();
        public void operation()
        {
            this.q1.Enqueue(100);
            this.q1.Enqueue(200);
            this.q1.Enqueue(300);
            this.q1.Enqueue(400);
            //this.q1.Dequeue();
            //if (this.q1.Count > 0)
            //{
            //    int topItem = this.q1.Peek();
            //    Console.WriteLine($"Top item is {topItem}");
            //}
            //else
            //{
            //    Console.WriteLine("Queue is empty.");
            //}

            //Console.WriteLine(this.q1.Contains(200));

            this.q1.Clear();

        }

        public void displayQueue()
        {
            foreach (var item in this.q1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
