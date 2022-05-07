using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : LLamada
    {
        protected float costo;
        public override float CostaLlamada { get { return CalcularCosto(); } }
        public Local(LLamada llamada, float costo) :
            this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo) :
            base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.AppendLine($"Costo LLamada {this.CostaLlamada}");
            return datos.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private float CalcularCosto()
        {
            return base.Duracion * costo;
        }
    }
}
