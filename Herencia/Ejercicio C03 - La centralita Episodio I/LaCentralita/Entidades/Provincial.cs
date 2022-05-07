using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Provincial : LLamada
    {

        public enum Franja { Franja_1, Franja_2, Franja_3 }
        protected Franja franjaHoraria;

        public override float CostaLlamada { get { return CalcularCosto(); } }

        public Provincial(Franja miFranja, LLamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
            
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }
        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.AppendLine($"Costo LLamada {this.CostaLlamada}");
            return datos.ToString();
        }
        private float CalcularCosto()
        {
            float resultado = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    resultado = 0.99F;
                    break;
                case Franja.Franja_2:
                    resultado = 1.25F;
                    break;
                case Franja.Franja_3:
                    resultado = 0.66F;
                    break;
            }
            return resultado * base.Duracion;
        }
        public override string ToString()
        {
            return this.Mostrar(); 
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial && obj is not null;
        }
    }
}
