using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoBase.Dominio;

namespace ProyectoBase.Test
{
    [TestClass]
    public class OrdenDeProduccionTest
    {
        [TestMethod]
        public void AgregarUnParDePrimera()
        {
            // Arrange
            var ordenDeProduccion = new OrdenDeProduccion();


            // Act
            ordenDeProduccion.AgregarPar("Primera");

            // Assert
            Assert.AreEqual(1, ordenDeProduccion.Pares.Count);

        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var ordenDeProduccion = new OrdenDeProduccion();

            // Act
            ordenDeProduccion.AgregarDefecto();

            // Assert


        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var ordenDeProduccion = new OrdenDeProduccion();


            // Act


            // Assert


        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange



            // Act


            // Assert


        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange



            // Act


            // Assert


        }
    }
}
