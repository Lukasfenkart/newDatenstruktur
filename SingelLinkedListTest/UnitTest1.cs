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
        public void Test2()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.add(new Node(1));
            linkedList.add(new Node(2));
            linkedList.add(new Node(3));
            Assert.AreEqual(3, linkedList.size());
        }
    }
}