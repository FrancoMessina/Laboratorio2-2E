using System;
using Entidades;
namespace Vista
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dolar original = new Dolar(1);
            Euro sameE = new Euro(1);
            Dolar sameD = new Dolar(0.92);
            Console.WriteLine($"Dolar: ${sameD.GetCantidad()} - Euro: ${sameE.GetCantidad()} -> Equally: {sameE == sameD}");
            Console.ReadKey();
        }
    }
}
