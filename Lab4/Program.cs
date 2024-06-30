using Lab_4;
using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //Student s1 = new Student();
        //s1.getList();
        //s1.Display();

        //StudentStack s1 = new StudentStack();
        //s1.getStack();
        //s1.display();

        StudentQueue s1 = new StudentQueue();
        s1.operation();
        s1.displayQueue();
    }
}