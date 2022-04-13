using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;
        public Camion(short cantidadPuertas, short cantidadRuedas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadPuertas, cantidadRuedas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }
        //Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short,
        //color : Colores, cantidadMarchas : short, pesoCarga : int.
    }
}
