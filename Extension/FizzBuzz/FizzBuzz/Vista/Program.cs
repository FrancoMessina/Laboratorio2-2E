using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }
        }
    }
}
