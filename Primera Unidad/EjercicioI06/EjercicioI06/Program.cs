using System;
using System.Collections.Generic;
namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribir un programa que determine si un año es bisiesto.

                Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son
                múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

                Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
             */
            Console.WriteLine(VerificarBisiesto(2024));
            List<int> aniosBisiestos;
            Console.WriteLine("Ingresa año de inicio : ");
            bool esNumero = int.TryParse(Console.ReadLine(), out int fechaInicio);
            while (!esNumero)
            {
                Console.WriteLine("Error... Ingresa año de inicio : ");
                esNumero = int.TryParse(Console.ReadLine(), out  fechaInicio);
            }
            Console.WriteLine("Ingresa año de Fin : ");
            esNumero = int.TryParse(Console.ReadLine(), out int fechaFin);
            while (!esNumero)
            {
                Console.WriteLine("Error...Ingresa año de Fin : ");
                esNumero = int.TryParse(Console.ReadLine(), out fechaFin);
            }
            
            aniosBisiestos = CargarAniosBisiestos(fechaInicio, fechaFin);
            MostrarAniosBisiestos(aniosBisiestos);
            Console.ReadKey();
        }
        public static bool VerificarBisiesto(int numero)
        {
            bool esBisiesto = false;
            if (numero % 4 == 0 || (numero % 100 == 0 && numero % 400 == 0))
                esBisiesto = true;
            return esBisiesto;
        }
        public static List<int> CargarAniosBisiestos(int inicio, int fin)
        {
            List<int> lista = new List<int>();
            for(int i = inicio; i <= fin; i++)
            {
                if(VerificarBisiesto(i))
                    lista.Add(i);
            }

            return lista;
        }
        public static void MostrarAniosBisiestos(List<int> aniosBisiestos)
        {
            Console.WriteLine("Años bisiestos : ");
            foreach (int anio in aniosBisiestos)
            {
                Console.WriteLine(anio);
            }
        }
    }
}
