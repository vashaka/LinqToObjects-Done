using System;
using NUnit.Framework;
using static Linq.PartitioningData;

namespace Linq.Tests
{
    [TestFixture]
    public class PartitioningDataTests
    {
        [Test]
        public void TakeTest()
        {
            var expected = new[] {5, 4, 1};
            CollectionAssert.AreEqual(expected, Take());
        }

        //[Test]
        //public void CustomersTakeTest()
        //{
        //    var expected = new[]
        //    {
        //        ("LAZYK", 10482, DateTime.Parse("21-Mar-97")),
        //        ("LAZYK", 10545, DateTime.Parse("22-May-97")),
        //        ("TRAIH", 10574, DateTime.Parse("19-Jun-97"))
        //    };
        //    CollectionAssert.AreEqual(expected, CustomersTake());
        //}

        [Test]
        public void SkipTest()
        {
            var expected = new[] {9, 8, 6, 7, 2, 0};
            CollectionAssert.AreEqual(expected, Skip());
        }
        
        [Test]
        public void TakeWhileTest()
        {
            var expected = new[] {5, 4, 1, 3};
            CollectionAssert.AreEqual(expected, TakeWhile());
        }
        
        [Test]
        public void IndexedTakeWhileTest()
        {
            var expected = new[] {5, 4};
            CollectionAssert.AreEqual(expected, IndexedTakeWhile());
        }
        
        [Test]
        public void SkipWhileTest()
        {
            var expected = new[] {3, 9, 8, 6, 7, 2, 0};
            CollectionAssert.AreEqual(expected, SkipWhile());
        }
        
        [Test]
        public void IndexedSkipWhileTest()
        {
            var expected = new[] { 1, 3, 9, 8, 6, 7, 2, 0};
            CollectionAssert.AreEqual(expected, IndexedSkipWhile());
        }
    }
}