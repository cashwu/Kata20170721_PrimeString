using System;
using System.Linq;
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

        [TestMethod]
        public void abac_Should_Be_PrimeString()
        {
            AssertShouldBePrimeString("abac");
        }

        [TestMethod]
        public void abab_Should_Not_Be_PrimeString()
        {
            AssertShouldNotBePrimeString("abab");
        }

        [TestMethod]
        public void aaaa_Should_Not_Be_PrimeString()
        {
            AssertShouldNotBePrimeString("aaaa");
        }

        [TestMethod]
        public void abc_Should_Be_PrimeString()
        {
            AssertShouldBePrimeString("abc");
        }

        [TestMethod]
        public void fdsyffdsyffdsyffdsyffdsyf_Should_Not_Be_PrimeString()
        {
            AssertShouldNotBePrimeString("fdsyffdsyffdsyffdsyffdsyf");
        }

        [TestMethod]
        public void utdutdtdutd_Should_Be_PrimeString()
        {
            AssertShouldBePrimeString("utdutdtdutd");
        }

        [TestMethod]
        public void abba_Should_Be_PrimeString()
        {
            AssertShouldBePrimeString("abba");
        }

        [TestMethod]
        public void abba_with_whiteSpace_Should_Be_PrimeString()
        {
            AssertShouldBePrimeString("ab ba");
        }

        [TestMethod]
        public void abab_with_whiteSpace_Should_Not_Be_PrimeString()
        {
            AssertShouldNotBePrimeString("ab ab");
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
        public bool PrimeString(string source)
        {
            for (int i = 1; i <= CheckPrimeStringTimes(source); i++)
            {
                if (SourceCanReplacePrimeString(source, source.Substring(0, i)))
                {
                    return false;
                }
            }

            return true;
        }

        private static int CheckPrimeStringTimes(string source)
        {
            return source.Length / 2;
        }

        private static bool SourceCanReplacePrimeString(string source, string primeString)
        {
            return source.Replace(primeString, "").Trim() == "";
        }
    }
}
