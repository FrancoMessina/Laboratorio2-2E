using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            setNombre(nombre);
            setFechaNacimiento(fechaDeNacimiento);
            setDni(dni);
        }
        public Persona()
        {

        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void setDni(string dni)
        {
            this.dni = dni;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getFechaNacimiento()
        {
            return this.fechaDeNacimiento.ToString();
        }
        public string getDni()
        {
            return this.dni;
        }
        private int CalcularEdad()
        {
            DateTime fechaDateTime = DateTime.Now;
            TimeSpan difference = fechaDateTime.Date - fechaDeNacimiento.Date;
            int days = (int)difference.TotalDays;
            return days / 365;
        }
        public string Mostrar()
        {
            return $"Nombre :{this.nombre}, Edad : {CalcularEdad()}, Dni: {this.dni}";
        }
        public string EsMayorDeEdad()
        {
            if (CalcularEdad() > 17)
                return "Es mayor de edad.";
            return "Es menor.";
        }

    }
}
