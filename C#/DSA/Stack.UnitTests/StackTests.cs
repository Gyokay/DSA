using System;
using NUnit.Framework;

namespace Stack.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Count_EmptyStack_ShouldReturnCorrect()
        {
            var stack = new Stack<string>(5);
            const int expectedCount = 0;

            Assert.AreEqual(expectedCount, stack.Count);
        }

        [Test]
        public void Count_OneElementInStack_ShouldReturnCorrect()
        {
            var stack = new Stack<int>(5, 1);
            const int expectedCount = 1;

            Assert.AreEqual(expectedCount, stack.Count);
        }

        [Test]
        public void Push_OneElement_ShouldPushToStack()
        {
            var stack = new Stack<int>(5);

            const int expectedCount = 1;
            stack.Push(1);

            Assert.AreEqual(expectedCount, stack.Count);
        }

        [Test]
        public void Push_MoreThenStackCapacity_ShouldThrowWithCorrectMessage()
        {
            const int capacity = 5;
            const string expectedMessage = "Stack is full";
            var stack = new Stack<int>(capacity);

            for (int i = 0; i < capacity; i++)
            {
                stack.Push(i);
            }

            Assert.Throws<InvalidOperationException>(() => stack.Push(1), expectedMessage);
        }

        [Test]
        public void Peek_PassingElementToConstructor_ShouldReturnTopmostElement()
        {
            const string expectedElement = "foo";
            var stack = new Stack<string>(5, expectedElement);

            Assert.AreEqual(expectedElement, stack.Peek());
        }

        [Test]
        public void Peek_UsingPushToAddElement_ShouldReturnTopmostElement()
        {
            var stack = new Stack<int>(5);

            const int expectedElement = 3;
            stack.Push(1);
            stack.Push(2);
            stack.Push(expectedElement);

            Assert.AreEqual(expectedElement, stack.Peek());
        }

        [Test]
        public void Peek_EmptyStack_ShouldThrowWithCorrectMessage()
        {
            const string expectedMessage = "Stack is empty";
            var stack = new Stack<int>(5);

            Assert.Throws<InvalidOperationException>(() => stack.Peek(), expectedMessage);
        }

        [Test]
        public void Pop_ShouldPopTopmostElement()
        {
            const int expectedElement = 1;
            const int initialExpectedCount = 1;
            const int expectedCountAfterPop = 0;

            var stack = new Stack<int>(5, expectedElement);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(initialExpectedCount, stack.Count);
                Assert.AreEqual(expectedElement, stack.Pop());
                Assert.AreEqual(expectedCountAfterPop, stack.Count);
            });
        }

        [Test]
        public void Pop_FillStackCapacityAndPopAll_ShouldEmptyStack()
        {
            const int expectedCountAfterPop = 0;
            var stack = new Stack<int>(4);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.AreEqual(expectedCountAfterPop, stack.Count);
        }

        [Test]
        public void Pop_ShouldReturnTopmostElement()
        {
            const int theMeaningOfLife = 42;
            var stack = new Stack<int>(1, theMeaningOfLife);

            Assert.AreEqual(theMeaningOfLife, stack.Pop());
        }

        [Test]
    }
}
