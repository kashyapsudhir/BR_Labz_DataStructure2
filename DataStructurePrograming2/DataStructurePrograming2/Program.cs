using System;
using System.Runtime.ExceptionServices;

namespace DataStructurePrograming2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello data structure programing2 start");

            Queue Myqueue = new Queue();
            Myqueue.Enqueue(56);
            Myqueue.Enqueue(30);
            Myqueue.Enqueue(70);
            Myqueue.Dequeue();
            Console.WriteLine("your output");
            Myqueue.Displaye();


        }
    }
}
