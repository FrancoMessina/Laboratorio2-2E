using System;
using System.Text;
using System.Collections.Generic;
namespace Entidades
{
    public class Centralita
    {
        private List<LLamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get { return CalcularGanancia(TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(TipoLlamada.Todas); } }
        public List<LLamada> Llamadas { get { return listaDeLlamadas; } }

        public Centralita()
        {
            listaDeLlamadas = new List<LLamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (LLamada llamada in Llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if(llamada is Local)
                            ganancia += llamada.CostaLlamada;
                    break;
                    case TipoLlamada.Provincial:
                        if (llamada is Provincial)
                            ganancia += llamada.CostaLlamada;
                    break;
                    case TipoLlamada.Todas:
                            ganancia += llamada.CostaLlamada;
                    break;
                }
            }
            return ganancia;           
        }
        private string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Razon Social {razonSocial}");
            datos.AppendLine($"Ganancia Local: {GananciasPorLocal}");
            datos.AppendLine($"Ganancia Provincial: {GananciasPorProvincial}");
            datos.AppendLine($"Ganancia Total: {GananciasPorTotal}");
            datos.AppendLine($"Datos de las llamadas: ");
            foreach (LLamada llamada in Llamadas)
            {
                datos.AppendLine(llamada.ToString());
            }
            return datos.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(LLamada.OrdenarPorDuracion);
        }


        private void AgregarLlamada(LLamada nuevaLlamada)
        {
            if(nuevaLlamada is not null && listaDeLlamadas is not null)
            {
                listaDeLlamadas.Add(nuevaLlamada);
            }
        }
 
        public static bool operator ==(Centralita c, LLamada Llamada)
        {
            if(c is not null && Llamada is not null)
            {
                foreach (LLamada item in c.listaDeLlamadas)
                {
                    if (item == Llamada)
                        return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, LLamada Llamada)
        {
            return !(c == Llamada);
        }
        public static Centralita operator +(Centralita c, LLamada Llamada)
        {
            if(c != Llamada)
                c.listaDeLlamadas.Add(Llamada);
            return c;
        }
    }
}
