using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Area cuadrado : {CalculadoraDeArea.CalcularAreaCuadrado(2)}");
            Console.WriteLine($"Area cuadrado : {CalculadoraDeArea.CalcularAreaCuadrado(4)}");
            Console.WriteLine($"Area circulo : {CalculadoraDeArea.CalcularAreaCirculo(3.5)}");
            Console.WriteLine($"Area triangulo : {CalculadoraDeArea.CalcularAreaTriangulo(3.5, 6)}");
            Console.ReadKey();
        }
    }
}
