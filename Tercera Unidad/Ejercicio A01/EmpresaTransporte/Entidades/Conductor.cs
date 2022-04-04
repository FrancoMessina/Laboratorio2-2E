using System;
using System.Text;
namespace Entidades
{
    public class Conductor
    {
        private string nombre;
        private int[] kilometrosPorDia = new int[7];

        public Conductor(string nombre)
        {
            SetNombre(nombre);
            CargarKilometrosDefault();
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public int[] GetKilometrosPorDia()
        {
            return this.kilometrosPorDia;
        }
        public void SetNombre(string nombre)
        {
             this.nombre = nombre;
        }
        private void CargarKilometrosDefault()
        {
            for(int i = 0; i < this.kilometrosPorDia.Length; i++)
            {
                this.kilometrosPorDia[i] = 0;
            }
        }
        public bool SetKilometroDia(int dia, int cantidadKilometros)
        {
            if(dia > 0 && dia < 8)
            {
                switch (dia)
                {
                    case 1:
                        kilometrosPorDia[0] += cantidadKilometros;
                        break;
                    case 2:
                        kilometrosPorDia[1] += cantidadKilometros;
                        break;
                    case 3:
                        kilometrosPorDia[2] += cantidadKilometros;
                        break;
                    case 4:
                        kilometrosPorDia[3] += cantidadKilometros;
                        break;
                    case 5:
                        kilometrosPorDia[4] += cantidadKilometros;
                        break;
                    case 6:
                        kilometrosPorDia[5] += cantidadKilometros;
                        break;
                    case 7:
                        kilometrosPorDia[6] += cantidadKilometros;
                        break;
                }
                return true;
            }
            return false;
        }
        public string MostrarConductor()
        {
            StringBuilder datosConductor = new StringBuilder();
            int[] listaKilometros = GetKilometrosPorDia();
            datosConductor.AppendLine($"Nombre : {this.GetNombre()}");
            for (int i = 0; i < listaKilometros.Length; i++)
            {
                datosConductor.AppendLine($"Dia {i+1}: {listaKilometros[i]} kilometros");
            }
            return datosConductor.ToString();
        }
        
    }
}
