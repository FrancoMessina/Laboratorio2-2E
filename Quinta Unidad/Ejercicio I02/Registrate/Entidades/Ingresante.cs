using System;
using System.Text;
namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private decimal edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais,string[] cursos,decimal edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.edad = edad;
            this.cursos = cursos;
        }
        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"Direccion: {this.direccion}");
            mensaje.AppendLine($"Edad: {this.edad}");
            mensaje.AppendLine($"Genero: {this.genero}");
            mensaje.AppendLine($"Pais: {this.pais}");
            mensaje.AppendLine($"Curso/s:");
            foreach (string curso in cursos)
            {
                if(curso is not null)
                    mensaje.AppendLine($"{curso}");
            }
            return mensaje.ToString();
        }
    }
}
