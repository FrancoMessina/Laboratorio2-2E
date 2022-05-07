using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private int cantidadPasajeros;
        private short cantidadMarchas;
        public Automovil(short cantidadPuertas, short cantidadRuedas, Colores color, int cantidadPasajeros, short cantidadMarchas) : base(cantidadPuertas, cantidadRuedas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
