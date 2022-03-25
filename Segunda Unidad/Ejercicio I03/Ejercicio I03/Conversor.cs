using System;
using System.Text;
namespace LogicaNegocio
{
    public class Conversor
    {
        public string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder sbBinario = new StringBuilder();
            string binarioFinal;
            do
            {
                if (numeroEntero % 2 == 0)
                    sbBinario.Append("0");
                else
                    sbBinario.Append("1");
                numeroEntero = numeroEntero / 2;

            } while (numeroEntero > 0);
            binarioFinal = InvertirString(sbBinario.ToString());
            return binarioFinal;
        }
        private static string InvertirString(string palabra)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(palabra[i]);
            }
            return stringBuilder.ToString();
        }
        public int ConvertirBinarioADecimal(int numeroEntero) 
        {

            string binarioTexto = numeroEntero.ToString();
            binarioTexto = InvertirString(binarioTexto);
            int multiplicador = 1;
            int acumulador = 0;
            for (int i = 0; i < binarioTexto.Length; i++)
            {
                int aux = (int.Parse(binarioTexto[i].ToString())) * multiplicador;
                acumulador += aux; 
                multiplicador *= 2;
            }
            return acumulador;
        }

    }
}
