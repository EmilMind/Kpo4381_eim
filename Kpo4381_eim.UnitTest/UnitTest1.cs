using System;
using System.Collections.Generic;
using Kpo4381.eim.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Kpo4381.eim.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProfitMethod()
        {
            List<OfficePacks> officePacks = new List<OfficePacks>();

            officePacks.Add(
                new OfficePacks()
                {
                    name = "test1",
                    vendor = "test1",
                    composition = 1,
                    price = 90
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test2",
                    vendor = "test2",
                    composition = 3,
                    price = 50
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test3",
                    vendor = "test3",
                    composition = 5,
                    price = 80
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test4",
                    vendor = "test4",
                    composition = 10,
                    price = 40
                });
            OfficePacks office = OfficePacksMethodProfit.Method(officePacks);
            Assert.AreEqual(office.name, officePacks[3].name);

        }
        [TestMethod]
        public void TestProfitIsNotNull()
        {
            List<OfficePacks> officePacks = new List<OfficePacks>();

            officePacks.Add(
                new OfficePacks()
                {
                    name = "test1",
                    vendor = "test1",
                    composition = 1,
                    price = 90
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test2",
                    vendor = "test2",
                    composition = 3,
                    price = 50
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test3",
                    vendor = "test3",
                    composition = 5,
                    price = 80
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test4",
                    vendor = "test4",
                    composition = 10,
                    price = 40
                });
            OfficePacks office = OfficePacksMethodProfit.Method(officePacks);
            Assert.IsNotNull(office);

        }
        [TestMethod]
        public void TestProfitError2()
        {
            List<OfficePacks> officePacks = new List<OfficePacks>();

            officePacks.Add(
                new OfficePacks()
                {
                    name = "test1",
                    vendor = "test1",
                    composition = 1,
                    price = 90
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test2",
                    vendor = "test2",
                    composition = 3,
                    price = 50
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test3",
                    vendor = "test3",
                    composition = 5,
                    price = 80
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test4",
                    vendor = "test4",
                    composition = 10,
                    price = 40
                });
            Assert.ThrowsException<Exception>(() => { OfficePacksMethodProfit.Method(null); });
        }
        [TestMethod]
        public void TestConvertingPrices()
        {
            List<OfficePacks> officePacks = new List<OfficePacks>();

            officePacks.Add(
                new OfficePacks()
                {
                    name = "test1",
                    vendor = "test1",
                    composition = 1,
                    price = 9000
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test2",
                    vendor = "test2",
                    composition = 3,
                    price = 5000
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test3",
                    vendor = "test3",
                    composition = 5,
                    price = 8000
                });
            officePacks.Add(
                new OfficePacks()
                {
                    name = "test4",
                    vendor = "test4",
                    composition = 10,
                    price = 4000
                });

            Assert.AreEqual((int)Math.Floor(officePacks[0].price * OfficePacksMethodConvertUSD.GetRUBUSDRate()), OfficePacksMethodConvertUSD.ConvertPricesToUsd(officePacks)[0].price);
                }

        [TestMethod]
        public void TestBrokenApi()
        {
            Assert.ThrowsException<BrokenApiException>(() => OfficePacksMethodConvertUSD.GetRUBUSDRate());
        }
    }
}
