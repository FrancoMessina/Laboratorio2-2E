using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;
        private short cantidadMarchas;
        public Moto(short cantidadPuertas, short cantidadRuedas, Colores color, short cantidadMarchas, short cilindrada) : base(cantidadPuertas, cantidadRuedas, color, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
