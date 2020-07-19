using System;
using System.Collections.Generic;
using ExpectedObjects;
using LinqLab.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqLab.Tests
{
    [TestClass()]
    public class FirstAndSingleLabTests
    {
        private FirstAndSingleLab _firstAndSingleLab;

        [TestInitialize]
        public void TestInitialize()
        {
            _firstAndSingleLab = new FirstAndSingleLab(new SampleData().Data);
        }

        [TestMethod]
        public void GetUserNameIsDemoByFirstTest()
        {
            var expected =
                new Sample
                {
                    Id = 1,
                    UserName = "demo",
                    CreateTime = new DateTime(2016, 1, 20),
                    Price = 800,
                    Items = new List<int> { 97, 92, 81, 60 }
                }.ToExpectedObject();

            var actual = _firstAndSingleLab.GetUserNameIsDemoByFirst();

            expected.ShouldEqual(actual);
        }

        [TestMethod]
        public void GetUserNameIsSkilltreeByFirstOrDefaultTest()
        {
            var actual = _firstAndSingleLab.GetUserNameIsSkilltreeByFirstOrDefault();
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetUserNameIsSkilltreeByFirstTest()
        {
            _firstAndSingleLab.GetUserNameIsSkilltreeByFirst();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetUserNameIsDemoBySingleTest()
        {
            _firstAndSingleLab.GetUserNameIsDemoBySingle();
        }

        [TestMethod]
        public void GetUserNameIsBillBySingleTest()
        {
            var expected =
                new Sample
                {
                    Id = 9,
                    UserName = "bill",
                    CreateTime = new DateTime(2016, 8, 20),
                    Price = 2000,
                    Items = new List<int> { 68, 79, 88, 92 }
                }.ToExpectedObject();

            var actual = _firstAndSingleLab.GetUserNameIsBillBySingle();

            expected.ShouldEqual(actual);
        }

        [TestMethod]
        public void GetUserNameIsBillBySingleOrDefaultTest()
        {
            var expected =
                new Sample
                {
                    Id = 9,
                    UserName = "bill",
                    CreateTime = new DateTime(2016, 8, 20),
                    Price = 2000,
                    Items = new List<int> { 68, 79, 88, 92 }
                }.ToExpectedObject();

            var actual = _firstAndSingleLab.GetUserNameIsBillBySingleOrDefault();

            expected.ShouldEqual(actual);
        }

        [TestMethod]
        public void GetUserNameIsSkilltreeBySingleOrDefaultTest()
        {
            var actual = _firstAndSingleLab.GetUserNameIsSkilltreeBySingleOrDefault();

            Assert.AreEqual(null, actual);
        }
    }
}