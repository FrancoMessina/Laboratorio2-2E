using System;

namespace Entidades
{
    public static class Calculador
    {
        public static int Calcular(int numeroUno, int numeroDos)
        {
            int resultado;
            try
            {
                resultado = numeroUno / numeroDos;    
            }
            catch (DivideByZeroException)
            {
                throw; // lanzo lo del catch
            }
            return resultado;
        }

    }
}
