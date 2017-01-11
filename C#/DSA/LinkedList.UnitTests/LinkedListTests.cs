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
        public void Add_ShouldAddToTheEndOfListWithCorrectData()
        {
            var list = new LinkedList<int>();

            int[] expectedNumbers = new int[] { 1, 5, 20 };
            list.Add(expectedNumbers[0]);
            list.Add(expectedNumbers[1]);
            list.Add(expectedNumbers[2]);

            Assert.AreEqual(expectedNumbers[0], list.Head.Data);
            Assert.AreEqual(expectedNumbers[1], list.Head.Next.Data);
            Assert.AreEqual(expectedNumbers[2], list.Head.Next.Next.Data);

        }

        //[Test]
        //public void Length_ShouldReturnCorrectLength()
        //{
        //    var LList = new LinkedList<int>();


        //}
    }
}
