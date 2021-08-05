using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            int nodePosition = linkedList.Search(30);
            linkedList.InsertAtParticularPosition(nodePosition + 1, 40);
            linkedList.Display();
        }
    }
}
