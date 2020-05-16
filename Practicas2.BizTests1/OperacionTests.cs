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
    public class OperacionTests
    {
        [TestMethod()]
        public void SumaTest()
        {
            //Arrange
            var operacion = new Operacion(1, 2);

            var expected = operacion.Suma();
            //Act
            var actual = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestaTest()
        {
            //Arrange
            var operacion = new Operacion(1, 2);

            var expected = operacion.Resta();
            //Act
            var actual = -1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            //Arrange
            var operacion = new Operacion(1, 2);

            var expected = operacion.Multiplicacion();
            //Act
            var actual = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            //Arrange
            var operacion = new Operacion(2, 2);

            var expected = operacion.Division();
            //Act
            var actual = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}