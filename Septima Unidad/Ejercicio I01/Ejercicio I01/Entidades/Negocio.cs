using System;
using System.Collections.Generic;


namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;


        public Cliente Cliente 
        { 
            get { return clientes.Dequeue(); }
            set 
            {
                bool resultado = this + value;
                    
            } 
        }

        private Negocio()
        {
           this.clientes = new Queue<Cliente>();
           this.caja = new PuestoAtencion(Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool  operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente cliente in n.clientes) 
            {
                if (cliente == c)
                    return true;
            }

            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
                return false;
            n.clientes.Enqueue(c);
            return true;
        }
        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count > 0)
                return n.caja.Atender(n.Cliente);
            return false;
        }
    }
}
