using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Append(70);
            int position = linkedList.Search(56);
            linkedList.InsertAtParticularPosition(position + 1, 30);
            linkedList.Display();
        }
    }
}
