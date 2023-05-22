using System;
using System.Runtime.ExceptionServices;

namespace DataStructurePrograming2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello data structure programing2 start");

            Stack myStack = new Stack();
            myStack.push(70);
            myStack.push(30);
            myStack.push(56);
            myStack.peek();
           
        }
    }
}
