using System;

namespace LogicaNegocio
{
    public class Calculadora
    {
        /*
         * Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando
         * y la operación matemática. El método devolverá el resultado de la operación.
         */
        public static float Calcular(int primerNumero, int segundoNumero, string operacion)
        {
            float resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado =  primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    resultado = (float)primerNumero / segundoNumero;
                    break;
            }
            return resultado;
        }
    }
}
