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
        public void TestInsertAfter_MultipleElements_ElementsAreAdded()
        {




        }
        [Test]
        public void TestGetNode_MultipleElements_ReturnsElement()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.GetNode(0);
            linkedList.addlast(2);
            linkedList.addlast(3);
            linkedList.addlast(4);
            linkedList.deletelast();
        }
        [Test]
        public void TestDeleteNode_FromTheMiddle_ElementIsDeleted()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addlast(1);
            linkedList.addlast(2);
            linkedList.addlast(3);
            linkedList.addlast(4);
            linkedList.deletelast();
        }
        [Test]
        public void TestAddLast_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addlast(1);
            linkedList.addlast(2);
            linkedList.addlast(3);
            linkedList.addlast(4);
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.data, 1);
            Assert.AreEqual(node.next.data, 2);
            Assert.AreEqual(node.next.next.data, 3);
            Assert.AreEqual(node.next.next.next.data, 4);
            Assert.AreEqual(4, linkedList.size());
        }
        [Test]
        public void TestAddFirst_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addfirst(1);
            linkedList.addfirst(2);
            linkedList.addfirst(3);
            linkedList.addfirst(4);
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.data, 4);
            Assert.AreEqual(node.next.data, 3);
            Assert.AreEqual(node.next.next.data, 2);
            Assert.AreEqual(node.next.next.next.data, 1);
            Assert.AreEqual(4, linkedList.size());
        }
    }
}