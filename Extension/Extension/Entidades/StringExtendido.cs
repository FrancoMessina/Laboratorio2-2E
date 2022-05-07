using System;

namespace Entidades
{
    public static class StringExtendido
    {
        //Tiene que ser estatico
        //Parametro primero this seguido el tipo en este caso String
        //y como ultimo la referencia 
        public static int ContarPalabras(this String s)
        {
            return s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
