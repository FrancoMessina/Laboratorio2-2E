using System;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigo;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return $"Marca : {p.marca}, Codigo de Barra: {(string)p}, Precio: {p.precio}";
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        //== (Producto, Producto): Retornará true si las marcas y
        //códigos de barra son iguales, false caso contrario.
        public static bool operator == (Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }
        public static bool operator != (Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        //== (Producto, string): Retornará true si la marca del producto coincide
        //con la cadena pasada como argumento, false caso contrario.

        public static bool operator ==(Producto p1, string marca)
        {
            return p1.marca == marca;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }
    }
}
