using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_PrimeString
{
    [TestClass]
    public class PrimeStringTests
    {
        [TestMethod]
        public void a_Should_Be_PrimeString()
        {
            AssertShouldBePrimeString("a");
        }

        private static void AssertShouldBePrimeString(string s)
        {
            var actual = new Kata().PrimeString(s);
            Assert.IsTrue(actual);
        }
    }

    public class Kata
    {
        public bool PrimeString(string s)
        {
            return true;
        }
    }
}
