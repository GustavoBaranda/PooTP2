using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    abstract class Servicio
    {
        protected double PrecioLista;

        public Servicio(double precioLista)
        {
            PrecioLista = precioLista;
        }
        public abstract double CalcularPrecio();
    }
}
