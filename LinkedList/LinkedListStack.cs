using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedListStack
    {
        private Node<int> top;
        public LinkedListStack()
        {
            this.top = null;
        }

        internal void Push(int value)
        {
            Node<int> node = new Node<int>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }

        internal void Display()
        {
            Node<int> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
