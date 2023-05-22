using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograming2
{
    public class Stack
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data) //Constructor
            {
                this.data = data;
            }

        }
        public Node Top;

        public void push(int data)
        {
            Node newNode = new Node(data);
            if (this.Top == null)
            {
                newNode.next = this.Top;
            }
            this.Top = newNode;
            Console.WriteLine($" The new top element is : {data}");
        }

        public void peek()
        {
            Node node = this.Top;
            Console.WriteLine($"The top element is : {node.data}");
        }

        


    }
}
