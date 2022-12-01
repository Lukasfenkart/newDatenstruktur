using NUnit.Framework;
using Common;

namespace SortAlgorythmTest
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestStrategyPattern_BubbleSort_Insert1856_Expectet1568()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.SetSortStrategy(new BubbleSort());
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
            linkedList.SetSortStrategy(new BubbleSort());
            linkedList.insertlast(1);
            linkedList.Sort();
            Assert.AreEqual(linkedList.GetFirst().data, 1);

        }
    }
}
