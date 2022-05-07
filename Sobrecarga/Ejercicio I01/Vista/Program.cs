using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(2);
            Console.WriteLine($"La suma de dos long es: {sumador.Sumar(45, 2)}");
            Console.WriteLine($"La suma de dos string es: {sumador.Sumar("Hola ", "Mundo")}");
            int cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumador+sumador2);
            Console.ReadKey();
        }
    }
}
