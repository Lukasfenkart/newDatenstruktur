using NUnit.Framework;


namespace SortAlgorythmTest
{
    public class RecursionTestRec
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Sum_FixNumber_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var iterative = ms.SumUpValues_Iterative(3);
            var recursive = ms.SumUpValues_Recursive(3);
            Assert.AreEqual(iterative, recursive);
        }
        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }
            public int SumUpValues_Recursive(int number)
            {
                if (number == 1)
                {
                    return number;
                }
                return number + SumUpValues_Recursive(number - 1);
            }
        }
    }
}