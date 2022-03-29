using System;
using Entidades;
namespace Vista
{
    public class Program
    {
        static void Main(string[] args)
        {

            Estudiante a1 = new Estudiante("Franco", "Messina", "0001");
            Estudiante a2 = new Estudiante("Leonel", "Ledesma", "0002");
            Estudiante a3 = new Estudiante("Esteban", "Prieto", "0003");
            a1.SetNotaPrimerParcial(6);
            a2.SetNotaPrimerParcial(3);
            a3.SetNotaPrimerParcial(9);
            a1.SetNotaSegundoParcial(5);
            a2.SetNotaSegundoParcial(7);
            a3.SetNotaSegundoParcial(7);
            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());
            Console.WriteLine(a3.Mostrar());

            Console.ReadKey();
        }
    }
}
