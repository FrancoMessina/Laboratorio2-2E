using System;
using System.Text;
namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        private float CalcularPromedio(int notaPrimerParcial, int notaSegundoParcial)
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
        }
        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial > 3 && this.notaSegundoParcial > 4)
                return random.Next(6,11);
            return -1;
        }
        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            double notaFinal = CalcularNotaFinal();
            mensaje.AppendLine($"Nombre : {this.nombre}, Apellido : {this.apellido} y Legajo : {this.legajo}");
            mensaje.AppendLine($"Nota del primer parcial : {this.notaPrimerParcial}. Nota del segundo parcial : {this.notaSegundoParcial}");
            mensaje.AppendLine($"Promedio : {CalcularPromedio(this.notaPrimerParcial, this.notaSegundoParcial)}");
            if (notaFinal != -1)
                mensaje.AppendLine($"La nota final es : {notaFinal}");
            else
                mensaje.AppendLine("Alumno desaprobado");
            return mensaje.ToString();
        }
    }
}
