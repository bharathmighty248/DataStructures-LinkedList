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
            linkedLists.Add(40);
            linkedLists.Add(70);
            linkedLists.DeleteParticularElement(40);
            int actualSize = linkedLists.Size();
            Assert.AreEqual(3,actualSize);
        }
    }
}