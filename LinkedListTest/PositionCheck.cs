using LinkedList;
using NUnit.Framework;
using System.Collections.Generic;

namespace LinkedListTest
{
    public class Tests
    {
        LinkedLists linkedLists = new LinkedLists();
        [Test]
        public void SearchElement_WhenFound_ShouldReturnNode()
        {
            linkedLists.Add(56);
            linkedLists.Add(30);
            linkedLists.Add(70);
            int searchNode = linkedLists.Search(30);
            linkedLists.InsertAtParticularPosition(searchNode + 1, 40);
            int actualNode = linkedLists.Search(40);
            Assert.AreEqual(2,actualNode);
        }
    }
}