using System;
using LogicaNegocio;
namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

                Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
             */
            int numeroIngresado;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float promedio;
            int acumulador = 0;
            const int TOTAL_NUMEROS = 10;
            bool esNumero;
            for(int i = 0; i < TOTAL_NUMEROS; i++)
            {
                Console.WriteLine("Ingresa numero : ");
                esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (!esNumero || !Validador.Validar(numeroIngresado, -100, 100))
                {
                    Console.WriteLine("Error...Ingresa numero : ");
                    esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                acumulador += numeroIngresado;
                if(numeroIngresado < minimo)
                    minimo = numeroIngresado;
                if(numeroIngresado > maximo)
                    maximo = numeroIngresado;
            }
            promedio = (float)acumulador / TOTAL_NUMEROS;

            Console.WriteLine($"El promedio es {promedio}.\n El valor min ingresado es : {minimo} \n" +
                $"El valor maximo ingresado es : {maximo}");
        }
    }
}
