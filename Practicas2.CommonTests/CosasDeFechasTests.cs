using ActividadEval2;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActividadEval2.Tests
{
    [TestClass()]
    public class CosasDeFechasTests
    {
        [TestMethod()]
        public void DiaSemanaTest()
        {
            //Arrange
            var expected = DateTime.Now.Day.ToString();
            //Act
            var actual = CosasDeFechas.DiaSemana();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CuantofaltaTest()
        {
            //Arrange
            var expected = 5;

            //Act
            var actual = CosasDeFechas.Cuantofalta(DateTime.Now.AddDays(5));

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
