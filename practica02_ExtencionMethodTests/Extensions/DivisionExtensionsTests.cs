using Microsoft.VisualStudio.TestTools.UnitTesting;
using practica02_ExtencionMethod.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Extensions.Tests
{
    [TestClass()]
    public class DivisionExtensionsTests
    {
        [TestMethod()]
        public void DivisionEntreEnteros()
        {
            //Arrange
            decimal dividendo = 6;
            decimal divisor = 2;
            decimal vEsperado = 3;

            //Act
            decimal vReal = dividendo.Division(divisor);
            
            //Assert
            Assert.AreEqual(vEsperado, vReal);
        }

        [TestMethod()]
        public void DivisionConNumerosNegativos()
        {
            //Arrange
            decimal dividendo = -8;
            decimal divisor = 2;
            decimal vEsperado = -4;

            //Act
            decimal vReal = dividendo.Division(divisor);

            //Assert
            Assert.AreEqual(vEsperado, vReal);
        }
    }
}