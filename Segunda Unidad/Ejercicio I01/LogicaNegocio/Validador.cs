using System;

namespace LogicaNegocio
{
    public class Validador
    {
        public static bool Validar(int valor, int minimo, int maximo)
        {
            if(valor > minimo && valor < maximo)
                return true;
            return false;
        }
    }
}
