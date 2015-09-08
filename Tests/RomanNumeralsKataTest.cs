using Katas;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RomanNumeralsKataTest
    {
        private RomanNumerals _RomanNumerals;

        [SetUp]
        public void Initialize()
        {
            _RomanNumerals = new RomanNumerals();
        }
    
        [Test]
        public void OneToThree()
        {
            Assert.AreEqual("I", _RomanNumerals.GetRomanFromArabic(1));
            Assert.AreEqual("II", _RomanNumerals.GetRomanFromArabic(2));
            Assert.AreEqual("III", _RomanNumerals.GetRomanFromArabic(3));
        }

        [Test]
        public void Four()
        {
            Assert.AreEqual("IV", _RomanNumerals.GetRomanFromArabic(4));
        }

        [Test]
        public void Five()
        {
            Assert.AreEqual("V", _RomanNumerals.GetRomanFromArabic(5));
        }

        [Test]
        public void Six()
        {
            Assert.AreEqual("VI", _RomanNumerals.GetRomanFromArabic(6));
        }

        [Test]
        public void Nine()
        {
            Assert.AreEqual("IX", _RomanNumerals.GetRomanFromArabic(9));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual("X", _RomanNumerals.GetRomanFromArabic(10));
        }

        [Test]
        public void Twenty()
        {
            Assert.AreEqual("XX", _RomanNumerals.GetRomanFromArabic(20));
        }

        [Test]
        public void Thirty()
        {
            Assert.AreEqual("XXX", _RomanNumerals.GetRomanFromArabic(30));
        }

        [Test]
        public void Fourty()
        {
            Assert.AreEqual("XL", _RomanNumerals.GetRomanFromArabic(40));
        }

        [Test]
        public void Fifty()
        {
            Assert.AreEqual("L", _RomanNumerals.GetRomanFromArabic(50));
        }

        [Test]
        public void Ninety()
        {
            Assert.AreEqual("XC", _RomanNumerals.GetRomanFromArabic(90));
        }

        [Test]
        public void Hundred()
        {
            Assert.AreEqual("C", _RomanNumerals.GetRomanFromArabic(100));
        }

        [Test]
        public void FourHundred()
        {
            Assert.AreEqual("CD", _RomanNumerals.GetRomanFromArabic(400));
        }

        [Test]
        public void FiveHundred()
        {
            Assert.AreEqual("D", _RomanNumerals.GetRomanFromArabic(500));
        }

        [Test]
        public void NineHundred()
        {
            Assert.AreEqual("CM", _RomanNumerals.GetRomanFromArabic(900));
        }

        [Test]
        public void Thousand()
        {
            Assert.AreEqual("M", _RomanNumerals.GetRomanFromArabic(1000));
        }

        [Test]
        public void ARandomExample()
        {
            Assert.AreEqual("MCMXXVIII", _RomanNumerals.GetRomanFromArabic(1928));
        }

    }
}
