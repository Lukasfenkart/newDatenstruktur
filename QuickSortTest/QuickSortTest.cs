using NUnit.Framework;
using Quicksort;

namespace QuickSortTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQuickSort_Add3Ints_ListIsSortedCorrect()
        {
            int[] arr = new int[] { 15, 6, 23, -11, 2, 8, -22, 43, 31, 9 };
            Quicksort.Quicksort.Quick_Sort(arr, 0, arr.Length - 1);
            Assert.AreEqual(-4, arr[0]);
        }
    }
}