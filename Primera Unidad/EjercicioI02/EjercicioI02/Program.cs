using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ingresar un número y mostrar el cuadrado y el cubo del mismo.
             * Se debe validar que el número sea mayor que cero, caso contrario
             * , mostrar el mensaje: "ERROR. ¡Reingresar número!".
             */
            ;
            bool isNumber;
            Console.WriteLine("Ingresar numero : ");
            isNumber = int.TryParse(Console.ReadLine(), out int numero);
            while (numero < 0 || !isNumber)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!.");
                isNumber = int.TryParse(Console.ReadLine(), out numero);

            }
            Console.WriteLine($"Potencia de {numero} al cuadrado es : {Math.Pow(numero, 2)} \n" +
                $"Potencia de {numero} al cubo es : {Math.Pow(numero, 3)}");

        }
    }
}
