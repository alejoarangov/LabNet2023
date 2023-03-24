using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica03.Utils.Extensions.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void IsDigitTestWithDigit()
        {
            //Arrange
            string str = "1";
            bool vExpected = true;

            //Act
            bool vReal = str.IsDigit();

            //Assert
            Assert.AreEqual(vExpected, vReal);
        }

        [TestMethod()]
        public void IsDigitTestWithText()
        {
            //Arrange
            string str = "A";
            bool vExpected = false;

            //Act
            bool vReal = str.IsDigit();

            //Assert
            Assert.AreEqual(vExpected, vReal);
        }
    }
}