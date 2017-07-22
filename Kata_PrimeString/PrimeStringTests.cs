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

        [TestMethod]
        public void aa_Should_Not_Be_PrimeString()
        {
            AssertShouldNotBePrimeString("aa");
        }

        private static void AssertShouldNotBePrimeString(string s)
        {
            var actual = new Kata().PrimeString(s);
            Assert.IsFalse(actual);
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
            if (s.Length == 1)
            {
                return true;
            }

            var primeString = s.Substring(0, 1);
            if (s.Replace(primeString, "") == "")
            {
                return false;
            }

            return true;
        }
    }
}
