using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    abstract class Servicio
    {
         protected float _PrecioLista;

        public Servicio(float precioLista)
        {
            _PrecioLista = precioLista;
        }

        public abstract float CalcularPrecio();
    }
}
