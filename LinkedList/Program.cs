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
            linkedList.Add(40);
            linkedList.Add(70);
            linkedList.DeleteParticularElement(40);
            linkedList.Display();
            int finalSize = linkedList.Size();
            Console.WriteLine("\n" + finalSize);
        }
    }
}
