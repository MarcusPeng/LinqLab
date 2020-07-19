﻿using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using LinqLab.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqLab.Tests
{
    [TestClass()]
    public class WhereLabTests
    {
        private WhereLab _whereLab;

        [TestInitialize]
        public void TestInitialize()
        {
            _whereLab = new WhereLab(new SampleData().Data);
        }

        [TestMethod()]
        public void GetIdGreaterThen8Test()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 9,UserName = "bill",CreateTime = new DateTime(2016,8,20),Price = 2000,Items = new List<int> {68, 79, 88, 92}},
                new Sample{Id = 10,UserName = "maduka",CreateTime = new DateTime(2016,1,20),Price = 9572,Items = new List<int> {99, 82, 81, 79}}
            }.ToExpectedObject();

            var actual = _whereLab.GetIdGreaterThen8();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void GetPriceEqual200Test()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 8,UserName = "dino",CreateTime = new DateTime(2016,7,20),Price = 200,Items = new List<int> {92, 90, 83, 78}},
            }.ToExpectedObject();

            var actual = _whereLab.GetPriceEqual200();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void GetUserNameStartWithDTest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 1,UserName = "demo",CreateTime = new DateTime(2016,1,20),Price = 800,Items = new List<int> {97, 92, 81, 60}},
                new Sample{Id = 2,UserName = "demo",CreateTime = new DateTime(2016,2,20),Price = 1800,Items = new List<int> {75, 84, 91, 39}},
                new Sample{Id = 3,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 2000,Items = new List<int> {88, 94, 65, 91}},
                new Sample{Id = 4,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 600,Items = new List<int> {97, 89, 85, 82}},
                new Sample{Id = 8,UserName = "dino",CreateTime = new DateTime(2016,7,20),Price = 200,Items = new List<int> {92, 90, 83, 78}},
            }.ToExpectedObject();

            var actual = _whereLab.GetUserNameStartWithD();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void GetUserNameContainsETest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 1,UserName = "demo",CreateTime = new DateTime(2016,1,20),Price = 800,Items = new List<int> {97, 92, 81, 60}},
                new Sample{Id = 2,UserName = "demo",CreateTime = new DateTime(2016,2,20),Price = 1800,Items = new List<int> {75, 84, 91, 39}},
                new Sample{Id = 3,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 2000,Items = new List<int> {88, 94, 65, 91}},
                new Sample{Id = 4,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 600,Items = new List<int> {97, 89, 85, 82}},
                new Sample{Id = 5,UserName = "joey",CreateTime = new DateTime(2016,4,20),Price = 100,Items = new List<int> {35, 72, 91, 70}},
                new Sample{Id = 6,UserName = "joey",CreateTime = new DateTime(2016,5,20),Price = 8990,Items = new List<int> {99, 86, 90, 94}},
                new Sample{Id = 7,UserName = "joey",CreateTime = new DateTime(2016,6,20),Price = 2000,Items = new List<int> {93, 92, 80, 87}},
            }.ToExpectedObject();

            var actual = _whereLab.GetUserNameContainsE();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void GetUserNameEndWithOTest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 1,UserName = "demo",CreateTime = new DateTime(2016,1,20),Price = 800,Items = new List<int> {97, 92, 81, 60}},
                new Sample{Id = 2,UserName = "demo",CreateTime = new DateTime(2016,2,20),Price = 1800,Items = new List<int> {75, 84, 91, 39}},
                new Sample{Id = 3,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 2000,Items = new List<int> {88, 94, 65, 91}},
                new Sample{Id = 4,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 600,Items = new List<int> {97, 89, 85, 82}},
                new Sample{Id = 8,UserName = "dino",CreateTime = new DateTime(2016,7,20),Price = 200,Items = new List<int> {92, 90, 83, 78}},
            }.ToExpectedObject();

            var actual = _whereLab.GetUserNameEndWithO();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void GetUserNameInDemoAndJoeyTest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 1,UserName = "demo",CreateTime = new DateTime(2016,1,20),Price = 800,Items = new List<int> {97, 92, 81, 60}},
                new Sample{Id = 2,UserName = "demo",CreateTime = new DateTime(2016,2,20),Price = 1800,Items = new List<int> {75, 84, 91, 39}},
                new Sample{Id = 3,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 2000,Items = new List<int> {88, 94, 65, 91}},
                new Sample{Id = 4,UserName = "demo",CreateTime = new DateTime(2016,3,20),Price = 600,Items = new List<int> {97, 89, 85, 82}},
                new Sample{Id = 5,UserName = "joey",CreateTime = new DateTime(2016,4,20),Price = 100,Items = new List<int> {35, 72, 91, 70}},
                new Sample{Id = 6,UserName = "joey",CreateTime = new DateTime(2016,5,20),Price = 8990,Items = new List<int> {99, 86, 90, 94}},
                new Sample{Id = 7,UserName = "joey",CreateTime = new DateTime(2016,6,20),Price = 2000,Items = new List<int> {93, 92, 80, 87}},
            }.ToExpectedObject();

            var actual = _whereLab.GetUserNameInDemoAndJoey();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void IsContainsId99Test()
        {
            var expected = false;

            var actual = _whereLab.IsContainsId99();

            Assert.AreEqual(expected, actual);
        }
    }
}