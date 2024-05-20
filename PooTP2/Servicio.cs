using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    abstract class Servicio
    {
         protected double _PrecioLista;

        public Servicio(double precioLista)
        {
            _PrecioLista = precioLista;
        }
        public abstract double CalcularPrecio();
    }
}
