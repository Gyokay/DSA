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
        public void Length_AddOddNumberOfElements_ShouldReturnCorrectLength()
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
        public void Length_AddEvenNumberOfElements_ShouldReturnCorrectLength()
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
    }
}
