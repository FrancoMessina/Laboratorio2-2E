using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtendido
    {
        //Tiene que ser estatico
        //Parametro primero this seguido el tipo en este caso String
        //y como ultimo la referencia 
        public static int ContarPalabras(this String s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException();
            }
            return s.Split(new char [] {' ', '-'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
