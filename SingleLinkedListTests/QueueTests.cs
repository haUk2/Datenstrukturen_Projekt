using GenericList;
using MyStack;
using NUnit.Framework;
using Common;

namespace StackUnitTests
{
    class QueueObserver : IObserver
    {
        public int callCount = 0;
        public void Update(ISubject subject)
        {
            callCount++;
        }
    }
    public class QueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Enqueue_ThreeElements_QueueOrderOK()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "| 1 | 2 | 3 |");
        }

        [Test]
        public void EnqueueAndDeQueue_EnqueThreeTimesDequeueonce_TwoElementsInQueueFirstOneRemoved()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var first = queue.Dequeue();
            Assert.AreEqual(first.data, 1);
            Assert.AreEqual(queue.ToString(), "| 2 | 3 |");
        }

        [Test]
        public void Observer_EnqueDeque2Times_UpdteIsCalledTwice()
        {
            MyQueue queue = new MyQueue();
            QueueObserver queueObserver = new QueueObserver();
            queue.Attach(queueObserver);
            queue.Enqueue(1);
            queue.Dequeue();
            
            Assert.AreEqual(queueObserver.callCount, 2);
        }

        [Test]
        public void Observer_Observing2Queus_UpdteIsCalledForEachQueue()
        {
            MyQueue queue1 = new MyQueue();
            MyQueue queue2 = new MyQueue();
            QueueObserver queueObserver = new QueueObserver();
            queue1.Attach(queueObserver);
            queue2.Attach(queueObserver);
            queue1.Enqueue(1);
            queue1.Dequeue();
            Assert.AreEqual(queueObserver.callCount, 2);
            queue1.Enqueue(1);
            Assert.AreEqual(queueObserver.callCount, 3);

        }

    }
}