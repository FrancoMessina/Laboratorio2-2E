using System;
namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros
             * positivos (excluido el mismo) que son divisores del número.

               El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

               Escribir una aplicación que encuentre los 4 primeros números perfectos.
             */
            int cont = 0;
            int i = 1;
            do
            {         
                if(verificarNumPerfecto(i))
                {
                    Console.WriteLine($"Es numero perfecto {i}");
                    cont++;
                }                 
                i++;

            } while (cont != 4);
           Console.ReadKey();
        }
        public static bool verificarNumPerfecto(int num)
        {
            bool esPerfecto = false;
            int acum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    acum += i;
                if (acum == num)
                {
                    esPerfecto = true;
                }
                else if (acum > num)
                {
                    esPerfecto = false;
                    break;
                }
            }
            return esPerfecto;
        }
    }
}
