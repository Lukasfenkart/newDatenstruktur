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
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Quicksort.Quicksort Quick_Sort(arr, 0, arr.Length - 1);
            Assert.AreEqual(-4, arr[0]);
        }
    }
}