using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola Mundo";
            int contadorPalabras = StringExtendido.ContarPalabras(texto);//Verdad de la milanesa
            int contadorPalabras2 = texto.ContarPalabras();
            Console.WriteLine(contadorPalabras);
            Console.WriteLine(contadorPalabras2);
        }
    }
}
