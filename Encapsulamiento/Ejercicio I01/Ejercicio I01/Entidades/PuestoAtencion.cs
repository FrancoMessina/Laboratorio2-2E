using System;
using System.Threading;
namespace Entidades
{
    public enum Puesto
    {
        Caja1, Caja2
    }
    public class PuestoAtencion
    {
        
        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual
        { 
            get 
            {
                numeroActual++;
                return numeroActual; 
            } 
        }


        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {         
            Thread.Sleep(2000);
            return true;
        }
    }
}
