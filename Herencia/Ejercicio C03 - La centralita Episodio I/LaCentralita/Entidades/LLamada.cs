using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum TipoLlamada { Local, Provincial, Todas }
    public abstract class LLamada
    {
        
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostaLlamada {  get; }

        public float Duracion { get { return duracion; } }
        public string NroOrigen { get { return nroOrigen; } }
        public string NroDestino { get { return nroDestino; } }

        public LLamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }
        protected virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Duracion: {Duracion}");
            datos.AppendLine($"Número Origen: {nroOrigen}");
            datos.AppendLine($"Número Destino: {NroDestino}");
            return datos.ToString();
        }

        public static bool operator ==(LLamada l1, LLamada l2)
        {
            return l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen;
        }
        public static bool operator !=(LLamada l1, LLamada l2)
        {
            return !(l1 == l2);
        }

        public static int OrdenarPorDuracion(LLamada llamada1, LLamada llamada2)
        {
            return (int)(llamada1.Duracion - llamada2.Duracion);
        }
    }
}
