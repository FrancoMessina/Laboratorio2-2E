using System;
using LogicaNegocio;
namespace EjercicioI02
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Consigna#
                    Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

                    Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

                    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

             */
            int acumulador = 0;
            int numeroIngresado;
            bool esNumero;
            string respuesta;
            do
            {
                Console.WriteLine("Ingresa un numero : ");
                esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (!esNumero)
                {
                    Console.WriteLine("Error. Reingresar un numero valido : ");
                    esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                acumulador += numeroIngresado;
                Console.WriteLine("¿Desea continuar? (S/N).");
                respuesta = Console.ReadLine();
            }while (!Validador.ValidarRespuesta(respuesta));
            Console.WriteLine($"Total acumulado : {acumulador}");
        }

    }
}
