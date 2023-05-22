using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograming2
{
    public class Stack
    {
        private LinkedList stack = new LinkedList();

        public void Push(int data)
        {
            stack.AddToLast(data);
        }
        public void Pop()
        {
            stack.DeleteLast();
        }

        public void Display()
        {
            stack.Display();
        }

    }
}
