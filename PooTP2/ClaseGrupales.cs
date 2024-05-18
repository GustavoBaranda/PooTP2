using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class ClaseGrupales : ServiciosDeportivos
    {
        public string _tipoClase;
        public int _CantidadDeInscriptos;

        public ClaseGrupales(string tipoClase, int cantidadDeInscriptos, int duracion, string tipoDeServicio, float precio) 
            : base (duracion, tipoDeServicio, precio)
        {
            _tipoClase = tipoClase;
            _CantidadDeInscriptos = cantidadDeInscriptos;
        }
    }
}
