using System;
using ChickenSoftware.StockPriceAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChickenSoftware.StockPriceAnalyzer.Tests
{
    [TestClass]
    public class StockFinderTests
    {
        IStockFinder _stockFinder = null;
        public StockFinderTests()
        {
            _stockFinder = new InMemoryStockFinder();
        }

        [TestMethod]
        public void GetHighVolumeUpDay_ReturnsExpected()
        {
            var result = _stockFinder.GetHighVolumeUpDay("MSFT");
            Assert.IsNotNull(result);
        }
    }
}
