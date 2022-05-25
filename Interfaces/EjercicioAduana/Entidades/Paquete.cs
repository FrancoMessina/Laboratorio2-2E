using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Paquete
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        public abstract bool TienePrioridad { get; }

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }
    
        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo seguimiento : {codigoSeguimiento}");
            sb.AppendLine($"Codigo Envio : {costoEnvio}");
            sb.AppendLine($"Destino : {destino}");
            sb.AppendLine($"Origen : {origen}");
            sb.AppendLine($"Peso Kg : {pesoKg}");
            if(TienePrioridad)
                sb.AppendLine("Tiene prioridad");
            else
                sb.AppendLine("No tiene prioridad");
            return sb.ToString();
        }

    }
}
