using NUnit.Framework;
using Common;

namespace SortAlgorythmTest
{
    public class InsertionSortTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestStrategyPattern_Insertionsort_Insert1856_Expectet1568()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.SetSortStrategy(new Sort_InsertionSort());
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
        public void TestStrategyPattern_ReverseInsertionsort_Insert1856_expectet8651()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.SetSortStrategy(new ReversInsertionSort());
            linkedList.insertlast(1);
            linkedList.insertlast(8);
            linkedList.insertlast(5);
            linkedList.insertlast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.GetFirst().data, 8);
            Assert.AreEqual(linkedList.GetFirst().next.data, 6);
            Assert.AreEqual(linkedList.GetFirst().next.next.data, 5);
            Assert.AreEqual(linkedList.GetFirst().next.next.next.data, 1);
        }
    }
}