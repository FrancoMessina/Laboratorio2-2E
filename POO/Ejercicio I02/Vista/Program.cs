using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Console.WriteLine("Ingresar nombre : ");
            p1.setNombre(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de nacimiento con formato (dd/mm/yyyy)");
            p1.setFechaNacimiento(DateTime.Parse(Console.ReadLine()));
            Console.WriteLine("Ingresar dni : ");
            p1.setDni(Console.ReadLine());



            Console.WriteLine(p1.Mostrar());

            Console.ReadKey();
        }
    }
}
