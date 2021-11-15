using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestToRoman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositiveNumber()
        {
            string expect = "X";
            string result = ConvertToRoman.Program.ToRoman(10);
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestNegativeNumber()
        {
            string expect = "Value out of range";
            string result = ConvertToRoman.Program.ToRoman(-3);
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestDecimalNumber()
        {
            string expect = "IV";
            string result = ConvertToRoman.Program.ToRoman(4.4);
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestZeroNumber()
        {
            string expect = string.Empty;
            string result = ConvertToRoman.Program.ToRoman(0);
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestEmptyString()
        {
            
            string expect = "Must introduce a integer value between 1 and 3999";
            string result = ConvertToRoman.Program.ToRoman();
            Assert.AreEqual(expect, result);
        }
    }
}
