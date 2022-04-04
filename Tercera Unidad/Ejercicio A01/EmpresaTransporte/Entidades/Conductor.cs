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
        public Conductor()
        { 
           
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public int[] GetKilometros()
        {
            return this.kilometrosPorDia;
        }
        public int GetKilometros(int dia)
        {
            return this.kilometrosPorDia[dia - 1];
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
        public string MostrarDatosConductor()
        {
            StringBuilder datosConductor = new StringBuilder();
            int[] listaKilometros = GetKilometros();
            datosConductor.AppendLine($"Nombre : {this.GetNombre()}");
            for (int i = 0; i < listaKilometros.Length; i++)
            {
                datosConductor.AppendLine($"Dia {i+1}: {listaKilometros[i]} kilometros");
            }
            return datosConductor.ToString();
        }
        public static int CalcularKilometrosTotales(Conductor conductor)
        {
            int acumuladorKilometros = 0;
            int[] kilometrosDelConductor = conductor.GetKilometros();
            for (int i = 0; i < kilometrosDelConductor.Length; i++)
            {
                acumuladorKilometros += kilometrosDelConductor[i];
            }
            return acumuladorKilometros;
        }
        public static Conductor CalcularConductorMaximoKilometros(Conductor[] listaConductores)
        {
            Conductor conductorMaximoKilometros = new Conductor();
            int maximoKilometros = int.MinValue;
            int kilometrosConductor;
            for(int i = 0; i < listaConductores.Length; i++)
            {
                kilometrosConductor = CalcularKilometrosTotales(listaConductores[i]);
                if (kilometrosConductor > maximoKilometros)
                {
                    maximoKilometros = kilometrosConductor;
                    conductorMaximoKilometros = listaConductores[i];
                }
            }
            return conductorMaximoKilometros;
        }
        public static Conductor CalcularConductorMaximoKilometros(Conductor[] listaConductores, int dia)
        {
            Conductor conductorMaximoKilometros = new Conductor();
            int maximoKilometros = int.MinValue;
            int kilometrosConductor;
            for (int i = 0; i < listaConductores.Length; i++)
            {
                kilometrosConductor = listaConductores[i].GetKilometros(dia);
                if (kilometrosConductor > maximoKilometros)
                {
                    maximoKilometros = kilometrosConductor;
                    conductorMaximoKilometros = listaConductores[i];
                }
            }
            return conductorMaximoKilometros;
        }

    }
}
