using System;
using LogicaNegocio;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float primerNumero, segundoNumero, resultado;
            string operador, respuesta;
            bool esNumero;
            do
            {
                Console.WriteLine("Ingresar primer numero : ");
                esNumero = float.TryParse(Console.ReadLine(), out primerNumero);
                while (!esNumero)
                {
                    Console.WriteLine("Error...Ingresar numero : ");
                    esNumero = float.TryParse(Console.ReadLine(), out primerNumero);
                }
                Console.WriteLine("Ingresar segundo numero : ");
                esNumero = float.TryParse(Console.ReadLine(), out segundoNumero);
                while (!esNumero)
                {
                    Console.WriteLine("Error...Ingresar numero : ");
                    esNumero = float.TryParse(Console.ReadLine(), out segundoNumero);
                }
                Console.WriteLine("Ingresar operador : ");
                operador = Console.ReadLine();
                resultado = Calculadora.Calcular(primerNumero, segundoNumero, operador);
                Console.WriteLine($"El resultado es {resultado}");
                Console.WriteLine("Quires hacer otra operacion ? s/n");
                respuesta = Console.ReadLine();
                            
            } while (respuesta != "n");

        }
    }
}
