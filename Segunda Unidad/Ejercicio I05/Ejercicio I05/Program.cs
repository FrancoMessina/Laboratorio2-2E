using System;
using System.Text;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Consigna#
                Crear una aplicación de consola que permita al usuario ingresar un número entero.

                Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de
                ese número en formato string.

                Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el
                resultado.

                Mostrar en la consola el resultado.

                Por ejemplo, si se ingresa el número 2 la salida deberá ser:
             */
            Console.WriteLine("Ingresa numero  : ");
            int.TryParse(Console.ReadLine(), out int numeroIngresado);
            string tabla = DevolverTabla(numeroIngresado);
            Console.WriteLine(tabla);
        }
        public static string DevolverTabla(int num) 
        { 
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i < 10; i++)
            {
                sb.Append($"{num} x {i} = {i * num}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
