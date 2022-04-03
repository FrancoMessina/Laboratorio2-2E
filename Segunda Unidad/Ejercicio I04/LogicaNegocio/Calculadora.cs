using System;

namespace LogicaNegocio
{
    public class Calculadora
    {
        public static float Calcular(float n1, float n2, string operador)
        {
            float resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    if(Validar(n2))
                        resultado = n1 / n2;
                    break;
            }
            return resultado;
        }
        private static bool Validar(float numero)
        {
            return numero != 0;
        }

    }
}
