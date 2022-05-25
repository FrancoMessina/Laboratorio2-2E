using System;
using System.IO;
namespace Entidades
{
    public class GestorDeArchivo
    {
        public GestorDeArchivo()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Join(ruta, "misArchivitos");
            
        }
        public static bool Escribir(string ruta, string contenido)
        {
            StreamWriter streamWriter = new StreamWriter(ruta);

            return true;
        }
    }
}
