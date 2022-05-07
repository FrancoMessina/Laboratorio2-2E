using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
namespace TestExtendido
{
    [TestClass]
    public class StringTest
    {
        //Public void y [TestMethod]
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadaPorEspacio_DeberiaRetornarNumero2()
        {
            //Arrange
            string texto = "Hola Mundo";
            int expected = 2; //Lo que espero que me devuelva el metodo esperado
            int actual;

            //Act
            actual = texto.ContarPalabras();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadaPorGuion_DeberiaRetornarNumero2()
        {
            //Arrange
            string texto = "Hola-Mundo";
            int expected = 2; //Lo que espero que me devuelva el metodo.
            int actual;

            //Act
            actual = texto.ContarPalabras();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContarPalabras_CuandoRecibeDosStringVacio_DeberiaLanzarArgumentException()
        {
            //Arrange
            string texto = string.Empty;
            int expected = 2; //Lo que espero que me devuelva el metodo.

            //Act
            int actual = texto.ContarPalabras();

            //Assert
        }

    }
}
