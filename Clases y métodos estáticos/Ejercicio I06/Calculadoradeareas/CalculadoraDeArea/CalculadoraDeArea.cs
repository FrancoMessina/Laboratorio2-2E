using System;

namespace Entidades
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double baseT, double altura) 
        {
            return (baseT * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio) 
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
