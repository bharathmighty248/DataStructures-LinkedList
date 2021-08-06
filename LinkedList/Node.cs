using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
