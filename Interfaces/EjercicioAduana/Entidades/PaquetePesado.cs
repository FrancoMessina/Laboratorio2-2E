using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaquetePesado : Paquete
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad { get { return false; } }
        //Hereda de Paquete.
        //Implementa la propiedad TienePrioridad retornando false ya que los paquetes pesados NO tienen prioridad.
        //Implementar la prueba unitaria TienePrioridad_DeberiaRetornarFalse de la clase PaquetePesadoTest.
        //Deberá verificar que la propiedad TienePrioridad retorne false para las instancias de PaquetePesado.
    }
}
