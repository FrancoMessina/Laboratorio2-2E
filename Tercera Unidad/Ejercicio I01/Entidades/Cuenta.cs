using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        public string Mostrar()
        {
            return $"El titular es : {this.titular} y la Cantidad es : ${this.cantidad}";
        }

        public void Ingresar(decimal cantidad)
        {
            if(cantidad > 0)
                this.cantidad += cantidad;
        }
        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0)
                this.cantidad -= cantidad;
        }
    }

}
