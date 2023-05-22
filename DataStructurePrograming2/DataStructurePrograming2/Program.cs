using System;
using System.Runtime.ExceptionServices;

namespace DataStructurePrograming2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello data structure programing2 start");

            Stack Mystack = new Stack();
            Mystack.Push(23);
            Mystack.Push(31);
            Mystack.Push(33);
            Mystack.Pop();
            Mystack.Display();


        }
    }
}
