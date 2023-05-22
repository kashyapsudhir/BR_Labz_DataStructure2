using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograming2
{
    public class Queue
    {
        LinkedList queue = new LinkedList();

        public void Enqueue(int data)
        {
            queue.AddToLast(data);
        }

        public void Displaye()
        {
            queue.Display();
        }

    }
}
