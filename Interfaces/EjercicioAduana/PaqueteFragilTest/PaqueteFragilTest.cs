using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System;
using Entidades;
namespace TestUnitario
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("asd", 20, "Avellaneda", "San telmo", 5);
            bool expected = true;

            //Act
            bool actual = paqueteFragil.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
