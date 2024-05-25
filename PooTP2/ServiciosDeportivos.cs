using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    abstract class ServiciosDeportivos : Servicio
    {
        protected int Duracion;
        public ServiciosDeportivos(int duracion,double _PrecioLista ) : base(_PrecioLista)
        {
            Duracion = duracion;
        }
    }
}