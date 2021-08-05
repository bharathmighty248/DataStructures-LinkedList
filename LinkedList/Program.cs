using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Display();
            int nodePosition= linkedList.Search(30);
            Console.WriteLine("\n" + nodePosition);
        }
    }
}
