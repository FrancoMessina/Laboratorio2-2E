using System;
using LogicaNegocio;
using System.Collections.Generic;
namespace Ejercicio_I07
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Empleado> listaEmpleados = new List<Empleado>();
            int cantidadEmpleados;
            bool esNumero;
            Console.WriteLine("Ingresa la cantidad de empleados : ");
            esNumero = int.TryParse(Console.ReadLine(), out cantidadEmpleados);
            while (!esNumero)
            {
                Console.WriteLine("Error. Reingresa la cantidad de empleados : ");
                esNumero = int.TryParse(Console.ReadLine(), out cantidadEmpleados);
            }
            for(int i = 0 ; i < cantidadEmpleados; i++)
            {
                Empleado empleado = new Empleado();
                float valorHora;
                int antiguedadAnios;
                int cantidadHoras;
                Console.WriteLine("Ingresa nombre");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Ingresar valor por hora");
                float.TryParse(Console.ReadLine(), out valorHora);
                empleado.ValorHora = valorHora;
                Console.WriteLine("Ingresar cantidad horas");
                int.TryParse(Console.ReadLine(), out cantidadHoras);
                empleado.AntiguedadAnios = cantidadHoras;
                Console.WriteLine("Ingresar antiguedad Años");
                int.TryParse(Console.ReadLine(), out antiguedadAnios);
                empleado.AntiguedadAnios = antiguedadAnios;
                listaEmpleados.Add(empleado);
            }
            foreach (Empleado empleado in listaEmpleados)
            {
                empleado.MostrarInfoEmpleado();
            }
           
        }
    }
}
