using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsKataCCL
{
    [TestClass]
    public class ArabicToRoman_Tests
    {
        [TestMethod]
        public void ArabicNumber_1_Returns_I()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("I", arabicRomanParser.Convert(1));
        }

        [TestMethod]
        public void ArabicNumber_2_Returns_II()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("II", arabicRomanParser.Convert(2));
        }

        [TestMethod]
        public void ArabicNumber_3_Returns_III()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("III", arabicRomanParser.Convert(3));
        }

        [TestMethod]
        public void ArabicNumber_4_Returns_IV()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("IV", arabicRomanParser.Convert(4));
        }

        [TestMethod]
        public void ArabicNumber_5_Returns_V()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("V", arabicRomanParser.Convert(5));
        }

        [TestMethod]
        public void ArabicNumber_6_Returns_VI()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("VI", arabicRomanParser.Convert(6));
        }

        [TestMethod]
        public void ArabicNumber_7_Returns_VII()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("VII", arabicRomanParser.Convert(7));
        }

        [TestMethod]
        public void ArabicNumber_8_Returns_VIII()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("VIII", arabicRomanParser.Convert(8));
        }

        [TestMethod]
        public void ArabicNumber_9_Returns_IX()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("IX", arabicRomanParser.Convert(9));
        }

        [TestMethod]
        public void ArabicNumber_10_Returns_X()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("X", arabicRomanParser.Convert(10));
        }

        [TestMethod]
        public void ArabicNumber_15_Returns_XV()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("XV", arabicRomanParser.Convert(15));
        }

        [TestMethod]
        public void ArabicNumber_19_Returns_XIX()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("XIX", arabicRomanParser.Convert(19));
        }

        [TestMethod]
        public void ArabicNumber_20_Returns_XX()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("XX", arabicRomanParser.Convert(20));
        }

        [TestMethod]
        public void ArabicNumber_25_Returns_XXV()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("XXV", arabicRomanParser.Convert(25));
        }

        [TestMethod]
        public void ArabicNumber_49_Returns_XLIX()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("XLIX", arabicRomanParser.Convert(49)); // Super Bowl 49!
        }

        [TestMethod]
        public void ArabicNumber_50_Returns_L()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("L", arabicRomanParser.Convert(50));
        }

        [TestMethod]
        public void ArabicNumber_76_Returns_LXXVI()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("LXXVI", arabicRomanParser.Convert(76));
        }

        [TestMethod]
        public void ArabicNumber_80_Returns_LXXX()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("LXXX", arabicRomanParser.Convert(80));
        }

        [TestMethod]
        public void ArabicNumber_100_Returns_C()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("C", arabicRomanParser.Convert(100));
        }

        [TestMethod]
        public void ArabicNumber_500_Returns_D()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("D", arabicRomanParser.Convert(500));
        }

        [TestMethod]
        public void ArabicNumber_1000_Returns_M()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("M", arabicRomanParser.Convert(1000));
        }

        [TestMethod]
        public void ArabicNumber_1500_Returns_MD()
        {
            var arabicRomanParser = new ArabicToRomanConverter();
            Assert.AreEqual("MD", arabicRomanParser.Convert(1500));
        }
    }

}
