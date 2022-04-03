using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Consigna
             Crear una aplicación de consola que pida al usuario ingresar la base y la altura d
            e un triángulo en centímetros.

             El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

             Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

             Mostrar el resultado en la consola.
             */
            Console.WriteLine(CalcularLongitudHipotenusa(2, 2)); 
            Console.ReadKey();
        }
        public static double CalcularLongitudHipotenusa(float baseT, float altura)
        {
            return Math.Sqrt((Math.Pow(baseT,2)) + (Math.Pow(altura, 2)));
        }
    }
}
