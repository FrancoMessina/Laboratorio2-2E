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
            Conductor conductorMaxKms;
            Conductor conductorMaxKmsDia3;
            Conductor conductorMaxKmsDia5;
            for (int i = 0; i < conductores.Length; i++)
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
                Console.WriteLine(conductores[i].MostrarDatosConductor());
            }
            conductorMaxKms = Conductor.CalcularConductorMaximoKilometros(conductores);
            Console.WriteLine("Conductor con más kilometros acumulados!");
            Console.WriteLine(conductorMaxKms.MostrarDatosConductor());
            Console.WriteLine("Conductor Dia 3: con más kilometros acumulados!");
            conductorMaxKmsDia3 = Conductor.CalcularConductorMaximoKilometros(conductores,3);
            Console.WriteLine($"Nombre : {conductorMaxKmsDia3.GetNombre()}");
            Console.WriteLine("Conductor Dia 5: con más kilometros acumulados!");
            conductorMaxKmsDia5 = Conductor.CalcularConductorMaximoKilometros(conductores, 5);
            Console.WriteLine($"Nombre : {conductorMaxKmsDia5.GetNombre()}");
            Console.ReadKey();
        }
    }
}
