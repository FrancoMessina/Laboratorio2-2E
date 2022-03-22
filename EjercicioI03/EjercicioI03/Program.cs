using System;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

               Validar que el dato ingresado por el usuario sea un número.

               Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

               Si ingresa "salir", cerrar la consola.

               Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
             */
            bool isNumber;
            string salida;
            do
            {
                Console.WriteLine("Ingresa numero : ");
                isNumber = int.TryParse(Console.ReadLine(), out int numero);
                while (!isNumber)
                {
                    Console.WriteLine("Error. Ingresa numero : ");
                    isNumber = int.TryParse(Console.ReadLine(), out numero);
                }
                mostrarPrimos(numero);
                Console.WriteLine("Salir?: ");
                salida = Console.ReadLine();
            } while (salida.ToLower() != "salir");
            Console.WriteLine("Salida exitosa!");
        }
        public static void mostrarPrimos(int n)
        {
            bool esPrimo = true;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                    Console.WriteLine($"Es primo {i}");
                esPrimo = true;
            }
        }
    }
}

