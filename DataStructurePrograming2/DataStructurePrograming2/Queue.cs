using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograming2
{
    public class Queue
    {
        LinkedList Myqueue = new LinkedList();

        

        public void Enqueue(int data)
        {
            Myqueue.AddToLast(data);
        }
        public void Dequeue()
        {
            Myqueue.DeleteFirst();
        }
        public void Displaye()
        {
            Myqueue.Display();
        }

    }
}
