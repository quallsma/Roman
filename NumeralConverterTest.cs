using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class NumeralConverterTest
    {
        [TestMethod]
        public void ConvertToRoman1()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual("I", converter.ArabicToRoman(1));
        }

        [TestMethod]
        public void ConvertToRoman3()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual("III", converter.ArabicToRoman(3));
        }

        [TestMethod]
        public void ConvertToRoman9()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual("IX", converter.ArabicToRoman(9));
        }

        [TestMethod]
        public void ConvertToRoman1066()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual("MLXVI", converter.ArabicToRoman(1066));
        }

        [TestMethod]
        public void ConvertToRoman1989()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual("MCMLXXXIX", converter.ArabicToRoman(1989));
        }

        [TestMethod]
        public void ConvertToArabic1()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual(1, converter.RomanTOArabic("I"));
        }

        [TestMethod]
        public void ConvertToArabic3()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual(3, converter.RomanTOArabic("III"));
        }

        [TestMethod]
        public void ConvertToArabic9()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual(9, converter.RomanTOArabic("IX"));
        }

        [TestMethod]
        public void ConvertToArabic1066()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual(1066, converter.RomanTOArabic("MLXVI"));
        }

        [TestMethod]
        public void ConvertToArabic1989()
        {
            NumeralConverter converter = new NumeralConverter();
            Assert.AreEqual(1989, converter.RomanTOArabic("MCMLXXXIX"));
        }
    }
}
