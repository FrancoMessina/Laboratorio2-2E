using System;

namespace Entidades
{
    public enum Colores
    { 
        Rojo, Blanco, Azul, Gris, Negro 
    }
    public class VehiculoTerrestre
    {       
        private short cantidadPuertas;
        private short cantidadRuedas;
        private Colores color;
        public VehiculoTerrestre(short cantidadPuertas, short cantidadRuedas, Colores color, short cantidadMarchas)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }

        //Todas tienen cantidadRuedas, cantidadPuertas,Color,CantidadMarchas,
    }
}
