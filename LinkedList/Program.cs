using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
        }
    }
}
