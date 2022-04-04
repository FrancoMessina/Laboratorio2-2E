using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, kms;
            string nombre;
            Conductor[] conductores = new Conductor[3];
            for(int i = 0; i < conductores.Length; i++)
            {
                Console.WriteLine("Ingresar nombre del conductor.");
                nombre = Console.ReadLine();
                conductores[i] = new Conductor(nombre);
                for (int j = 0; j < 7; j++)
                {
                    dia = j + 1;
                    Console.WriteLine($"Ingresar kms del dia : {j + 1}");
                    int.TryParse(Console.ReadLine(), out kms);
                    conductores[i].SetKilometroDia(dia, kms);
                }
            }
            for(int i = 0; i < conductores.Length; i++)
            {
                Console.WriteLine(conductores[i].MostrarConductor());
            }
            Console.ReadKey();
        }
    }
}
