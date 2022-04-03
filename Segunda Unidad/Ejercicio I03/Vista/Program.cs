using System;
using LogicaNegocio;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = "10011";
            int dec = Convert.ToInt32(bin, 2);
            //Console.WriteLine(dec);
            Conversor validacion = new Conversor();
            int value1 = validacion.ConvertirBinarioADecimal(10011);
            Console.WriteLine(value1);
        }
    }
}
