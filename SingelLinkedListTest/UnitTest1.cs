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
        public void TestAddFirst_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(1);
            linkedList.insertfirst(2);
            linkedList.insertfirst(3);
            linkedList.insertfirst(4);
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.data, 4);
            Assert.AreEqual(node.next.data, 3);
            Assert.AreEqual(node.next.next.data, 2);
            Assert.AreEqual(node.next.next.next.data, 1);
            Assert.AreEqual(4, linkedList.size());
        }
        [Test]
        public void TestAddLast_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertlast(1);
            linkedList.insertlast(2);
            linkedList.insertlast(3);
            linkedList.insertlast(4);
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.data, 1);
            Assert.AreEqual(node.next.data, 2);
            Assert.AreEqual(node.next.next.data, 3);
            Assert.AreEqual(node.next.next.next.data, 4);
            Assert.AreEqual(4, linkedList.size());
        }
        [Test]
        public void TestDeleteNode_FromTheMiddle_ElementIsDeleted()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertlast(1);
            linkedList.insertlast(2);
            linkedList.insertlast(3);
            linkedList.insertlast(4);
            linkedList.deletelast();
            Assert.AreEqual(3, linkedList.size());
        }
        [Test]
        public void TestGetNode_MultipleElements_ReturnsElement()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.GetNode(0);
            linkedList.insertlast(2);
            linkedList.insertlast(3);
            linkedList.insertlast(4);
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.next.next.data, 4);
        }
        [Test]
        public void TestInsertAfter_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(1);
            linkedList.insertfirst(2);
            linkedList.insertfirst(3);
            linkedList.insertafter(linkedList.GetFirst(), 5);
            Assert.AreEqual(linkedList.GetFirst().next.data, 5);
        }
        
        [Test]
        public void TestSwitchNodes_BothNodesExist_NodesAreSwitched()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(1);
            linkedList.insertfirst(2);
            linkedList.insertfirst(3);
            var node = linkedList.GetFirst();
            linkedList.SwitchNodes(2, 3);
            Assert.AreEqual(node.next.data, 3);
        }
        [Test]
        public void TestSwitchNodes_SecondNodeIsFirstNode_NodesAreSwitched()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(2);
            linkedList.insertfirst(1);
            Node node = linkedList.GetFirst();
            Node node2 = linkedList.GetFirst().next;
            linkedList.Switch(node, node2);
            Assert.AreEqual(linkedList.GetFirst().data, 2);
        }
        [Test]
        public void TestSwitchNodesifexits_SecondNodeIsFirstNode_NodesAreSwitched()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(2);
            linkedList.insertfirst(1);
            Node node = linkedList.GetFirst();
            Node node2 = linkedList.GetFirst().next;
            linkedList.Switch(node, node2);
            Assert.AreEqual(linkedList.GetFirst().next.data, 1);
        }
        [Test]
        public void Testinsertionsort_insert4231_expectet1234()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertlast(4);
            linkedList.insertlast(2);
            linkedList.insertlast(3);
            linkedList.insertlast(1);
            linkedList.InsertionSort();
            Assert.AreEqual(linkedList.GetFirst().data, 1);
            Assert.AreEqual(linkedList.GetFirst().next.data, 2);
            Assert.AreEqual(linkedList.GetFirst().next.next.data, 3);
            Assert.AreEqual(linkedList.GetFirst().next.next.next.data, 4);
        }
    }
}