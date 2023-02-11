﻿using System;
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

        [Test]
        public void CustomersTakeTest()
        {
            var expected = new[]
            {
                ("LAZYK", 10482, DateTime.Parse("21-Mar-97")),
                ("LAZYK", 10545, DateTime.Parse("22-May-97")),
                ("TRAIH", 10574, DateTime.Parse("19-Jun-97"))
            };
            CollectionAssert.AreEqual(expected, CustomersTake());
        }

        [Test]
        public void SkipTest()
        {
            var expected = new[] {9, 8, 6, 7, 2, 0};
            CollectionAssert.AreEqual(expected, Skip());
        }

        [Test]
        public void CustomersSkipTest()
        {
            var expected = new[]
            {
                ("TRAIH", 10574, DateTime.Parse("19-Jun-97")),
                ("TRAIH", 10577, DateTime.Parse("23-Jun-97")),
                ("TRAIH", 10822, DateTime.Parse("08-Jan-98")),
                ("WHITC", 10269, DateTime.Parse("31-Jul-96")),
                ("WHITC", 10344, DateTime.Parse("01-Nov-96")),
                ("WHITC", 10469, DateTime.Parse("10-Mar-97")),
                ("WHITC", 10483, DateTime.Parse("24-Mar-97")),
                ("WHITC", 10504, DateTime.Parse("11-Apr-97")),
                ("WHITC", 10596, DateTime.Parse("11-Jul-97")),
                ("WHITC", 10693, DateTime.Parse("06-Oct-97")),
                ("WHITC", 10696, DateTime.Parse("08-Oct-97")),
                ("WHITC", 10723, DateTime.Parse("30-Oct-97")),
                ("WHITC", 10740, DateTime.Parse("13-Nov-97")),
                ("WHITC", 10861, DateTime.Parse("30-Jan-98")),
                ("WHITC", 10904, DateTime.Parse("24-Feb-98")),
                ("WHITC", 11032, DateTime.Parse("17-Apr-98")),
                ("WHITC", 11066, DateTime.Parse("01-May-98"))
            };
            CollectionAssert.AreEqual(expected, CustomersSkip());
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