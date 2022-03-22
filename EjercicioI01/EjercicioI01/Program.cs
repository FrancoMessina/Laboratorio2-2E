using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Consigna#
                Ingresar 5 números por consola, guardándolos en una variable escalar.
                Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
             */
            float numero;
            float min = float.MaxValue;
            float max = float.MinValue;
            float acum = 0;
            float promedio;
            const int VUELTAS = 5;
            for (int i = 0; i < VUELTAS; i++)
            {
                
                Console.WriteLine("Ingresa un numero : ");
                bool isNumber = float.TryParse(Console.ReadLine(), out numero);
                while (!isNumber)
                {
                    Console.WriteLine("Error...Ingresa un numero : ");
                    isNumber = float.TryParse(Console.ReadLine(), out numero);
                }
                if (numero > max)
                    max = numero;
                if (numero < min)
                    min = numero;
                acum += numero;
            }
            promedio = acum / VUELTAS;
            Console.WriteLine($"El promedio es : {promedio}. El max es {max}. El min es {min}");

        }
    }
}
