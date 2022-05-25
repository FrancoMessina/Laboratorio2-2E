using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace TestUnitario
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitalAfip()
        {
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paqueteFragil = new PaquetePesado("asd", 20, "Avellaneda", "San telmo", 50);
            bool expected = false;

            //Act
            bool actual = paqueteFragil.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
