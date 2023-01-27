using NUnit.Framework;
using Common;

namespace SortAlgorythmTest
{
    public class BubbleSortTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestStrategyPattern_BubbleSort_Insert1856_Expectet1568()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.SetSortStrategy(new Sort_BubbleSort());
            linkedList.insertlast(1);
            linkedList.insertlast(8);
            linkedList.insertlast(5);
            linkedList.insertlast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.GetFirst().data, 1);
            Assert.AreEqual(linkedList.GetFirst().next.data, 5);
            Assert.AreEqual(linkedList.GetFirst().next.next.data, 6);
            Assert.AreEqual(linkedList.GetFirst().next.next.next.data, 8);
        }
        [Test]
        public void TestStrategyPattern_BubbleSort_InsertNum1_ExpectetNoExeption()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.SetSortStrategy(new Sort_BubbleSort());
            linkedList.insertlast(1);
            linkedList.Sort();
            Assert.AreEqual(linkedList.GetFirst().data, 1);
        }
        [Test]
        public void TestReverseBubbleSort_BubbleSort_Insert1856_Expectet8651()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.SetSortStrategy(new BubbleSortDesc());
            linkedList.insertlast(1);
            linkedList.insertlast(8);
            linkedList.insertlast(5);
            linkedList.insertlast(6);
            linkedList.SortDesc();
            Assert.AreEqual(linkedList.ToString(), "| 8 | 6 | 5 | 1 |");
            Assert.AreEqual(linkedList.GetFirst().data, 8);
            Assert.AreEqual(linkedList.GetFirst().next.data, 6);
            Assert.AreEqual(linkedList.GetFirst().next.next.data, 5);
            Assert.AreEqual(linkedList.GetFirst().next.next.next.data, 1);
        }
    }
}
