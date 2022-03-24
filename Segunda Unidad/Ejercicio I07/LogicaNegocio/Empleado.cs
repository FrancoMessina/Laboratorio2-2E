using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Empleado
    {
        //Encapsulamiento
        private float valorHora;
        //private string nombre;
        private int cantidadHoras;
        private int antiguedadAnios;
        //Props
        public float ValorHora
        {
            get { return valorHora; }
            set
            {
                if (value > 0)
                    valorHora = value;
                else
                    valorHora = -1;
            }
        }
        public string Nombre { get; set; }
        public int CantidadHoras
        {
            set
            {
                if (value > 0)
                    cantidadHoras = value;
                else
                    cantidadHoras = -1;
            }
        }
        public int AntiguedadAnios
        {
            get { return antiguedadAnios; }
            set
            {
                if (value > 0)
                    antiguedadAnios = value;
                else
                    antiguedadAnios = -1;
            }
        }
        public float CalcularImporteBruto()
        {
            float cantidadXHoras = valorHora * cantidadHoras;
            float importeBruto;
            importeBruto = cantidadXHoras + (antiguedadAnios * 150);
            return importeBruto;
        }
        public float CalcularImporteNeto()
        {
            float descuento;
            float importeBruto;
            float importeNeto;
            importeBruto = CalcularImporteBruto();
            descuento = importeBruto * 13 / 100;
            importeNeto = importeBruto - descuento;
            return importeNeto;
        }
        /*
         * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
         * el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.


         */
        public void MostrarInfoEmpleado()//Esta funcion como contiene un CW deberia ir en vista no en Logica.
        {
            Console.WriteLine($"Nombre: {Nombre}\n" +
                              $"Valor por hora : {valorHora} \n" +
                              $"Antiguedad : {antiguedadAnios} \n" +
                              $"Importe bruto : {CalcularImporteBruto()}\n" +
                              $"Importe Neto : {CalcularImporteNeto()}");
        }
    }
}
