using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica03.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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