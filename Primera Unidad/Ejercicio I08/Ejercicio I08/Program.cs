using System;

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 5;
            
            for (int i = 0; i < altura; i++)
            {
                MostrarAstericos(i * 2); //
                Console.WriteLine();
            }
        }
        public static void MostrarAstericos(int cantidadAstericos)
        {
            for(int i = 0; i <= cantidadAstericos; i++)
            {
                Console.Write("*");
            }
        }
    }
}
