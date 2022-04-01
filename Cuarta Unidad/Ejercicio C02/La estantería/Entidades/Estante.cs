using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
            
        }
        public Estante(int capacidad, int ubicacionEstante) :this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estante)
        {
            Producto[] productosEstante = estante.GetProductos();
            StringBuilder mensajeEstantes = new StringBuilder();
            mensajeEstantes.AppendLine($"Ubicacion Estante: {estante.ubicacionEstante}");
            for (int i = 0; i < productosEstante.Length; i++)
            {
                if(!(productosEstante[i] is null))
                {
                    mensajeEstantes.AppendLine(Producto.MostrarProducto(productosEstante[i]));
                }
            }
            return mensajeEstantes.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            Producto[] productosEstante = e.GetProductos();
            for (int i = 0; productosEstante.Length < 0; i++)
            {
                if (productosEstante[i] == p)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
    }
}
