using Genericlist;
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
        public void Test1()
        {
            CustomStack<int> myStack = new CustomStack<int>();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            myStack.push(4);

            Assert.AreEqual(4, myStack.size());
            myStack.pop();
            Assert.AreEqual(3, myStack.size());

        }
    }
}