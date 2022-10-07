using LinkedList;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.add(new Node(1));
            linkedList.add(new Node(2));
            linkedList.add(new Node(3));
            linkedList.add(new Node(4));
            Assert.AreEqual(4, linkedList.size());
        }
    }
}