using System;
using NUnit.Framework;

namespace LinkedList.UnitTests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void Add_ShouldSetHeadNodeCorrectly()
        {
            var list = new LinkedList<int>();

            const int expectedNumber = 4;
            list.Add(expectedNumber);
            int actualNumber = list.Head.Data;

            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [Test]
        public void Add_IntData_ShouldAddToTheEndOfListWithCorrectData()
        {
            var list = new LinkedList<int>();

            var expectedNumbers = new int[] { 1, 5, 20 };
            list.Add(expectedNumbers[0]);
            list.Add(expectedNumbers[1]);
            list.Add(expectedNumbers[2]);

            Assert.AreEqual(expectedNumbers[0], list.Head.Data);
            Assert.AreEqual(expectedNumbers[1], list.Head.Next.Data);
            Assert.AreEqual(expectedNumbers[2], list.Head.Next.Next.Data);
        }

        [Test]
        public void Add_StringData_ShouldAddToTheEndOfListWithCorrectData()
        {
            var list = new LinkedList<string>();

            var expectedNumbers = new string[] { "foo", "bar", "baz" };
            list.Add(expectedNumbers[0]);
            list.Add(expectedNumbers[1]);
            list.Add(expectedNumbers[2]);

            Assert.AreEqual(expectedNumbers[0], list.Head.Data);
            Assert.AreEqual(expectedNumbers[1], list.Head.Next.Data);
            Assert.AreEqual(expectedNumbers[2], list.Head.Next.Next.Data);
        }

        [Test]
        public void Length_EmptyList_ShouldReturnCorrectLength()
        {
            var list = new LinkedList<int>();

            const int expectedLength = 0;
            var actualLength = list.Length();

            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void Length_SingleElement_ShouldReturnCorrectLength()
        {
            var list = new LinkedList<int>();

            list.Add(1);

            const int expectedLength = 1;
            var actualLength = list.Length();

            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void Length_OddNumberOfElements_ShouldReturnCorrectLength()
        {
            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            const int expectedLength = 3;
            var actualLength = list.Length();

            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void Length_EvenNumberOfElements_ShouldReturnCorrectLength()
        {
            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            const int expectedLength = 4;
            var actualLength = list.Length();

            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void Prepend_ShouldReplaceHeadNode()
        {
            var list = new LinkedList<string>();

            var expectedStrings = new string[] { "foo", "bar", "baz" };

            list.Add(expectedStrings[0]);
            list.Add(expectedStrings[1]);
            list.Prepend(expectedStrings[2]);

            Assert.AreEqual(expectedStrings[2], list.Head.Data);
            Assert.AreEqual(expectedStrings[0], list.Head.Next.Data);
            Assert.AreEqual(expectedStrings[1], list.Head.Next.Next.Data);
        }

        [Test]
        public void InsertAfter_EmptyArr_ShouldNotInsert()
        {
            var list = new LinkedList<string>();

            list.InsertAfter("foo", "bar");
            const int expectedLength = 0;

            Assert.AreEqual(expectedLength, list.Length());
        }

        [Test]
        public void InsertAfter_OneElement_ShouldInsert()
        {
            var list = new LinkedList<string>();

            const string expectedString = "bar";
            const int expectedLength = 2;

            list.Add("foo");
            list.InsertAfter("foo", expectedString);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedString, list.Head.Next.Data);
        }

        [Test]
        public void InsertAfter_BetweenTwoNodes_ShouldInsert()
        {
            var list = new LinkedList<string>();
            var expectedStrings = new string[] { "foo", "bar", "baz" };
            const int expectedLength = 3;

            list.Add(expectedStrings[0]);
            list.Add(expectedStrings[1]);
            list.InsertAfter("foo", expectedStrings[2]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedStrings[0], list.Head.Data);
            Assert.AreEqual(expectedStrings[2], list.Head.Next.Data);
            Assert.AreEqual(expectedStrings[1], list.Head.Next.Next.Data);
        }

        [Test]
        public void InsertAfter_NonExistantKey_ShouldNotInsert()
        {
            var list = new LinkedList<int>();
            var expectedNumbers = new int[] { 1, 2, 3 };
            var expectedLength = 2;

            list.Add(expectedNumbers[0]);
            list.Add(expectedNumbers[1]);
            list.InsertAfter(expectedNumbers[2], expectedNumbers[2]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedNumbers[0], list.Head.Data);
            Assert.AreEqual(expectedNumbers[1], list.Head.Next.Data);
        }

        [Test]
        public void InsertBefore_EmptyArr_ShouldNotInsert()
        {
            var list = new LinkedList<string>();

            list.InsertBefore("foo", "bar");
            const int expectedLength = 0;

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(null, list.Head);
        }

        [Test]
        public void InsertBefore_OneElement_ShouldInsert()
        {
            var list = new LinkedList<string>();

            var expectedStrings = new string[] { "foo", "bar" };
            const int expectedLength = 2;

            list.Add(expectedStrings[0]);
            list.InsertBefore(expectedStrings[0], expectedStrings[1]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedStrings[1], list.Head.Data);
            Assert.AreEqual(expectedStrings[0], list.Head.Next.Data);
        }

        [Test]
        public void InsertBefore_BetweenTwoNodes_ShouldInsert()
        {
            var list = new LinkedList<string>();
            var expectedStrings = new string[] { "foo", "bar", "baz" };
            const int expectedLength = 3;

            list.Add(expectedStrings[0]);
            list.Add(expectedStrings[1]);
            list.InsertBefore(expectedStrings[1], expectedStrings[2]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedStrings[0], list.Head.Data);
            Assert.AreEqual(expectedStrings[2], list.Head.Next.Data);
            Assert.AreEqual(expectedStrings[1], list.Head.Next.Next.Data);
        }

        [Test]
        public void InsertBefore_NonExistantKey_ShouldNotInsert()
        {
            var list = new LinkedList<int>();
            var expectedNumbers = new int[] { 1, 2, 3 };
            var expectedLength = 2;

            list.Add(expectedNumbers[0]);
            list.Add(expectedNumbers[1]);
            list.InsertBefore(expectedNumbers[2], expectedNumbers[2]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedNumbers[0], list.Head.Data);
            Assert.AreEqual(expectedNumbers[1], list.Head.Next.Data);
        }

        [Test]
        public void Delete_SingleElement_ShouldEmptyList()
        {
            var list = new LinkedList<string>();
            const string expectedString = "foo";
            const int expectedLength = 0;


            list.Add(expectedString);
            list.Delete(expectedString);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(null, list.Head);
        }

        [Test]
        public void Delete_LastElement_ShouldDeleteCorrectly()
        {
            var list = new LinkedList<string>();
            var expectedStrings = new string[] { "foo", "bar" };

            const int expectedLength = 1;


            list.Add(expectedStrings[0]);
            list.Add(expectedStrings[1]);
            list.Delete(expectedStrings[1]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedStrings[0], list.Head.Data);
            Assert.AreEqual(null, list.Head.Next);
        }

        [Test]
        public void Delete_MiddElement_ShouldDeleteCorrectly()
        {
            var list = new LinkedList<string>();
            var expectedStrings = new string[] { "foo", "bar", "baz" };

            const int expectedLength = 2;

            list.Add(expectedStrings[0]);
            list.Add(expectedStrings[1]);
            list.Add(expectedStrings[2]);
            list.Delete(expectedStrings[1]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedStrings[0], list.Head.Data);
            Assert.AreEqual(expectedStrings[2], list.Head.Next.Data);
        }

        [Test]
        public void Delete_FirstElementOfTwo_ShouldDeleteCorrectly()
        {
            var list = new LinkedList<string>();
            var expectedStrings = new string[] { "foo", "bar"};

            const int expectedLength = 1;

            list.Add(expectedStrings[0]);
            list.Add(expectedStrings[1]);
            list.Delete(expectedStrings[0]);

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(expectedStrings[1], list.Head.Data);
            Assert.AreEqual(null, list.Head.Next);
        }

        [Test]
        public void RemoveLast_OneElement_ShouldRemoveLastElement()
        {
            const int expectedLength = 0;
            var list = new LinkedList<int>();

            list.Add(1);
            list.RemoveLast();

            Assert.AreEqual(expectedLength, list.Length());
        }

        [Test]
        public void RemoveLast_OddNumberOfElements_ShouldRemoveCorrectly()
        {
            const int expectedLength = 1;
            var list = new LinkedList<string>();
            var elements = new string[] { "foo", "bar", "baz" };

            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(elements[i]);
            }

            list.RemoveLast();
            list.RemoveLast();

            Assert.AreEqual(expectedLength, list.Length());
            Assert.AreEqual(null, list.Head.Next);
        }

        [Test]
        public void RemoveLast_EmptyList_ShouldThrowWithCorrectMessage()
        {
            var list = new LinkedList<string>();

            Assert.Throws<InvalidOperationException>(() => list.RemoveLast(), "List is empty");
        }

        [Test]
        public void RemoveLast_SingleElementList_ShouldReturnRemovedValue()
        {
            var list = new LinkedList<int>();
            const int expectedNumber = 42;

            list.Add(expectedNumber);

            Assert.AreEqual(expectedNumber, list.RemoveLast());
        }

        [Test]
        public void RemoveLast_MultipleElementsList_ShouldReturnRemovedValue()
        {
            var list = new LinkedList<string>();
            var elements = new string[] { "foo", "bar", "baz" };

            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(elements[i]);
            }

            Assert.AreEqual(elements[2], list.RemoveLast());
            Assert.AreEqual(elements[1], list.RemoveLast());
        }
    }
}
