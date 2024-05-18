using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    abstract class Servicio
    {
        private float _Precio;

        public Servicio(float precio)
        {
            _Precio = precio;
        }
        public abstract float CalcularPrecio();
    }
}
