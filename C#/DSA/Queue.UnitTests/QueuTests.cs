using System;
using LinkedList;
using LinkedList.Contracts;
using Moq;
using NUnit.Framework;

namespace Queue.UnitTests
{
    [TestFixture]
    public class QueuTests
    {
        [Test]
        public void Enqueue_ShouldCallPrpendOnce()
        {
            var linkedListMock = new Mock<ILinkedList<int>>();
            var queue = new Queue<int>(linkedListMock.Object);

            queue.Enqueue(42);

            linkedListMock.Verify(x => x.Prepend(It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void Dequeue_ShouldCallRemoveLastOnce()
        {
            var linkedListMock = new Mock<ILinkedList<int>>();
            var queue = new Queue<int>(linkedListMock.Object);

            queue.Dequeue();

            linkedListMock.Verify(x => x.RemoveLast(), Times.Once());
        }

        [Test]
        public void Dequeue_WhenStackIsEmpty_ShouldThrowWithCorrectMessage()
        {
            var linkedListMock = new Mock<ILinkedList<int>>();
            linkedListMock.Setup(x => x.RemoveLast())
                .Throws<InvalidOperationException>();
            var queue = new Queue<int>(linkedListMock.Object);

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue(), "Queue is empty");
        }
    }
}
