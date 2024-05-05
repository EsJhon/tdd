using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMCD()
        {
            Assert.AreEqual(4, tdd.MCD(12, 8));
            Assert.AreEqual(5, tdd.MCD(25, 15));
            Assert.AreEqual(25, tdd.MCD(100, 75));
        }

        [TestMethod]
        public void TestMCD_CuatroNumeros()
        {
            Assert.AreEqual(4, tdd.MCD_CuatroNumeros(12, 8, 16, 4));
            Assert.AreEqual(5, tdd.MCD_CuatroNumeros(25, 15, 10, 5));
            Assert.AreEqual(25, tdd.MCD_CuatroNumeros(100, 75, 50, 25));
        }
    }
}