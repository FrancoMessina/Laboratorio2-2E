using System;
using Entidades;
namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta usuario = new Cuenta("pepe", 2000);
            Console.WriteLine(usuario.Mostrar());
            usuario.Ingresar(500);
            Console.WriteLine(usuario.Mostrar());
            usuario.Ingresar(-2000);
            usuario.Retirar(2000);
            Console.WriteLine(usuario.Mostrar());
            Console.ReadKey();
        }
    }
}
