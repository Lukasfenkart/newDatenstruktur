using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Common;

namespace SortAlgorythmTest
{
    public class SelectionSortTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestSelectionSort_Add3UnsortedNodes_ListIsSortedCorrect()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(3);
            linkedList.insertfirst(1);
            linkedList.insertlast(2);
            linkedList.SetSortStrategy(new SelectionSort());
            linkedList.Sort();
            Assert.AreEqual(linkedList.ToString(), "| 3 | 2 | 1 |");
        }
        [Test]
        public void TestSelectionSortDescending_Add3UnsortedNodes_ListIsSortedCorrect()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertfirst(3);
            linkedList.insertfirst(6);
            linkedList.insertfirst(4);
            linkedList.insertfirst(1);
            linkedList.insertfirst(7);
            linkedList.insertfirst(5);
            linkedList.insertlast(2);
            linkedList.SetSortStrategy(new SelectionSort());
            linkedList.Sort();
            Assert.AreEqual(linkedList.ToString(), "| 7 | 6 | 5 | 4 | 3 | 2 | 1 |");
        }
    }
}
