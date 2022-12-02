using NUnit.Framework;

namespace QueueTest
{
    public class QueueTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQueue_Enqueue123_Expect123()
        {
            Queue.Queue queue = new Queue.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "| 1 | 2 | 3 |");
        }
        [Test]
        public void TestQueue_Enqueue123Dequeue3_Expect12()
        {
            Queue.Queue queue = new Queue.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var retval = queue.Dequeue();    
            Assert.AreEqual(1, retval.data);
            Assert.AreEqual(queue.ToString(), "| 2 | 3 |");
        }
    }
}