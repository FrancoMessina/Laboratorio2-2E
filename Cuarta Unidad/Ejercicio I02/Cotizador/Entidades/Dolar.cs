using System;

namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar; 

        static Dolar()
        {
            cotzRespectoDolar = 1;   
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static explicit operator Euro(Dolar d)
        {
            double cantidad = d.GetCantidad() * cotzRespectoDolar;
            Euro euro = new Euro(cantidad);
            return euro;
        }
    }
}
