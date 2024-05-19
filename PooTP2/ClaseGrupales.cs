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

        public ClaseGrupales(string tipoClase, int cantidadDeInscriptos, int _Duracion ) 
            : base (_Duracion, 80)
        {
            _tipoClase = tipoClase;
            _CantidadDeInscriptos = cantidadDeInscriptos;
        }

        public override double CalcularPrecio()
        {
            double precioClases = _Duracion * _PrecioLista;
            precioClases = (_CantidadDeInscriptos > 10 ) ? precioClases *0.80 : precioClases ;
            double precioClasesFinal = precioClases += precioClases*0.105;
            return Math.Round(precioClasesFinal,2);
        }

        public override string ToString()
        {
            double result = CalcularPrecio();
            return $"Clase: {_tipoClase}, Precio por minuto: ${_PrecioLista},Duracion de la clase en Min: {_Duracion}, Cant de Inscriptos: {_CantidadDeInscriptos}, Precio total de la clase: ${result}";
        }
    }
}
