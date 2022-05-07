using System;
using System.Collections.Generic;
namespace EjercicioI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Un centro numérico es un número que separa una lista de números enteros 
             * (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

               El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
               cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos:
               (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

              Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola
             */
            List<int> listaCentrosNumericos;
            Console.WriteLine("Ingresa un numero : ");
            bool esNumero = int.TryParse(Console.ReadLine(), out int numUsuario);
            
            while (!esNumero)
            {
                Console.WriteLine("Error... Ingresa un numero : ");
                esNumero = int.TryParse(Console.ReadLine(), out numUsuario);
            }
            listaCentrosNumericos =  ListaNumCentros(numUsuario);
            if(listaCentrosNumericos == null)
                Console.WriteLine("No hay centros numericos");
            else
                MostrarCentricosNumericos(listaCentrosNumericos);

        }
        public static bool VerificarCentroNumerico(int numero)
        {
            int acumIzq = 0;
            int acumDerecha = 0;
            for (int i = 1; i < numero; i++)
            {
                acumIzq += i;
            }
            while (acumIzq > acumDerecha)
            {
                numero++;
                acumDerecha += numero;
                if (acumIzq == acumDerecha)
                    break;
            }
            if (acumIzq == acumDerecha)
                return true;
            return false;
        }
        public static List<int> ListaNumCentros(int numIngresado) //Retorna una lista de int, en la cual son centros numericos.
        {
            List<int> numerosCentro = new List<int>();
            for (int i = 2; i <= numIngresado; i++)
            {
                if (VerificarCentroNumerico(i))
                    numerosCentro.Add(i);
            }
            if (numerosCentro.Count == 0)
                return null;
            return numerosCentro;
        }
        public static void MostrarCentricosNumericos(List<int> numerosCentro)
        {
            foreach (int numCentro in numerosCentro)
            {
                Console.WriteLine(numCentro);
            }
        }
    }
}
