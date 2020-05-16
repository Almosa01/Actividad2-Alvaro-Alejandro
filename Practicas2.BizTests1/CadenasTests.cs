using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadEval2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEval2.Tests
{
    [TestClass()]
    public class CadenasTests
    {
        [TestMethod()]
        public void PrimerCaracterTest()
        {
            //Arrange
            var cadena = new Cadenas("hola");

            var expected = 'h';
            //Act
            var actual = cadena.PrimerCaracter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UltimoCaracterTest()
        {
            //Arrange
            var cadena = new Cadenas("hola");

            var expected = 'a';
            //Act
            var actual = cadena.UltimoCaracter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ElegirCaracterTest()
        {
            //Arrange
            var cadena = new Cadenas("hola");

            var expected = "o";
            //Act
            var actual = cadena.ElegirCaracter(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}