using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 0.92;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
           cotzRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            double cantidad = e.GetCantidad() / cotzRespectoDolar;
            Peso peso = new Peso(cantidad);
            return peso;
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return  !(e == d);
        }
    }
}
