using System;
using Entidades;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Local pepe = new Local("13131",23, "3", 3);
            Local asd = new Local("13131",25, "3", 3);
            if(asd == pepe)
            {

            }
            Console.WriteLine("Hello World!");
        }
    }
}
