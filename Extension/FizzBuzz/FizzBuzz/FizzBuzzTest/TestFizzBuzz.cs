using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
namespace FizzBuzzTest
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void FizzBuzz_CuandoReciboNumeroDivisibleSoloPorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 3;
            string expected = "Fizz" ; //Lo que espero que me devuelva el metodo

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoReciboNumeroDivisibleSoloPorCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 5;
            string expected = "Buzz"; //Lo que espero que me devuelva el metodo

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoReciboNumeroDivisiblePorCincoYTres_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz"; //Lo que espero que me devuelva el metodo

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(2,"2")]
        [DataRow(4,"4")]
        public void FizzBuzz_CuandoReciboNumeroNoEsDivisiblePorCincoOTres_DeberiaRetornarElNumero(int n, string expected)
        {

            //Act
            string actual = n.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
